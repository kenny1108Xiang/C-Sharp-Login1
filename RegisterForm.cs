using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Back_to_Login_button_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Close();
        }

        private void account_get_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)))
            {
                if (!char.IsControl(e.KeyChar))
                {
                    MessageBox.Show("只允許輸入數字、大小寫英文字母", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // 取消输入
                }
            }
        }

        private void name_get_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                if (!char.IsControl(e.KeyChar))
                {
                    MessageBox.Show("只允許輸入數字、大小寫英文字母", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // 取消输入
                }
            }
        }

        private void Clear_TextBox()
        {
            name_get.Clear();
            account_get.Clear();
            password_get.Clear();
            checkPassword_get.Clear();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string name = name_get.Text.Trim();
            string account = account_get.Text.Trim();
            string password = password_get.Text;
            string checkPassword = checkPassword_get.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("請輸入使用者名稱", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_TextBox();
                return;
            }

            if (!name.Equals(name.Trim()))
            {
                MessageBox.Show("開頭與結尾不可為空白字符", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_TextBox();
                return;
            }

            if (string.IsNullOrEmpty(account))
            {
                MessageBox.Show("請輸入帳號", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox();
                return;
            }

            if (password != checkPassword)
            {
                MessageBox.Show("輸入的兩次密碼不符", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox();
                return;
            }

            // Validated, proceed to save to database
            string connectionString = "Data Source=Data.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkNameQuery = "SELECT COUNT(*) FROM Data WHERE name = @name"; //先確認是否有相同的name
                    using (SQLiteCommand checkNameCommand = new SQLiteCommand(checkNameQuery, connection))
                    {
                        checkNameCommand.Parameters.AddWithValue("@name", name);
                        int nameCount = Convert.ToInt32(checkNameCommand.ExecuteScalar());

                        if (nameCount > 0)
                        {
                            MessageBox.Show("已經有相同名稱", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Clear_TextBox();
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO Data (name, account, password) VALUES (@name, @account, @password)";
                    using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@name", name);
                        insertCommand.Parameters.AddWithValue("@account", account);
                        insertCommand.Parameters.AddWithValue("@password", password);

                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("註冊成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear_TextBox();
                        this.Close();
                        Login_Form login_Form = new Login_Form();
                        login_Form.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"註冊時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }
}
