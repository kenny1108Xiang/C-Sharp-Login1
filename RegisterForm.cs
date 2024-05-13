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
                    MessageBox.Show("只允許輸入數字、大小寫英文字母與空白字元", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // 取消输入
                }
            }
        }

        private void Clear_TextBox()
        {
            Clear_TextBox("all"); // 默認傳入num為all，及為默認全部的textbox皆清空
        }

        private void Clear_TextBox(string type)
        {
            switch (type)
            {
                case "all":
                    name_get.Clear();
                    account_get.Clear();
                    password_get.Clear();
                    checkPassword_get.Clear();
                    break;
                case "name":
                    name_get.Clear();
                    break;
                case "account":
                    account_get.Clear();
                    break;
                case "password_and_check":
                    password_get.Clear();
                    checkPassword_get .Clear();
                    break;
            }
           
        }

        private async void register_button_Click(object sender, EventArgs e)
        {
            string name = name_get.Text.Trim();
            string account = account_get.Text.Trim();
            string password = password_get.Text;
            string checkPassword = checkPassword_get.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("請輸入使用者名稱", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_TextBox("name");
                return;
            }

            if (name != name.Trim())
            {
                MessageBox.Show("開頭與結尾不可為空白字符", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_TextBox("name");
                return;
            }

            if (string.IsNullOrEmpty(account))
            {
                MessageBox.Show("請輸入帳號", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox("account");
                return;
            }
            else if (account != account.Trim())
            {
                MessageBox.Show("開頭與結尾不可為空白字符", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_TextBox("account");
                return;
            }

            if (password != checkPassword)
            {
                MessageBox.Show("輸入的兩次密碼不符", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox("password_and_check");
                return;
            }
            else if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(checkPassword)) {
                MessageBox.Show("請輸入密碼欄位與確認密碼欄位", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox("password_and_check");
                return;
            }

            progressBar1.Visible = true;
            for (int i = 0; i <= 100; i += 10)
            {
                progressBar1.Value = i;
                await Task.Delay(80);
            }
            progressBar1.Visible = false;

            string connectionString = "Data Source=Data.db;Version=3;";
            SQLiteConnection connection = null;

            try
            {
                connection = new SQLiteConnection(connectionString);
                await connection.OpenAsync();

                string checkNameQuery = "SELECT COUNT(*) FROM Data WHERE name = @name";
                using (SQLiteCommand checkNameCommand = new SQLiteCommand(checkNameQuery, connection))
                {
                    checkNameCommand.Parameters.AddWithValue("@name", name);
                    int nameCount = Convert.ToInt32(await checkNameCommand.ExecuteScalarAsync());

                    if (nameCount > 0)
                    {
                        MessageBox.Show("已經有相同名稱", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Clear_TextBox("name");
                        return;
                    }
                }

                string insertQuery = "INSERT INTO Data (name, account, password) VALUES (@name, @account, @password)";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@name", name);
                    insertCommand.Parameters.AddWithValue("@account", account);
                    insertCommand.Parameters.AddWithValue("@password", password);

                    await insertCommand.ExecuteNonQueryAsync();

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
            finally
            {
                // 確保始終關閉資料庫連接
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }
    }
}
