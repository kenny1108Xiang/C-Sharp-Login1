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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp1
{
    public partial class Login_Form : Form
    {
        public static string UserName { get; set; }
        public static string UserOp { get; set; }
        public static string Password { get; set; }

        public static string connectionString { get; } = "Data Source=Data.db;Version=3;";
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Show_password_Click(object sender, EventArgs e)
        {
            this.Password_get.UseSystemPasswordChar = false;
            this.Hide_password.Visible = true;
            this.Show_password.Visible = false;
        }

        private void Hide_password_Click(object sender, EventArgs e)
        {
            this.Password_get.UseSystemPasswordChar = true;
            this.Hide_password.Visible = false;
            this.Show_password.Visible = true;
        }

        private void Clear_TextBox()
        {
            Account_get.Clear();
            Password_get.Clear();
        }
        private async void Login_button_Click(object sender, EventArgs e)
        {
            if (Account_get.TextLength == 0 || Password_get.TextLength == 0) {
                MessageBox.Show("帳號與密碼不得為空");
            } else {
                string account = this.Account_get.Text;
                string password = this.Password_get.Text;
                string sql = "SELECT name, op FROM Data WHERE account = @account AND password = @password";
                progressBar_Login.Visible = true;
                for (int i = 0; i <= 100; i += 10)
                {
                    progressBar_Login.Value = i;
                    System.Threading.Thread.Sleep(80); // 模擬花費時間
                }
                progressBar_Login.Visible = false;

                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        await connection.OpenAsync();

                        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@account", account);
                            command.Parameters.AddWithValue("@password", password);

                            using (SQLiteDataReader reader = (SQLiteDataReader)command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string name = reader["name"].ToString();
                                    string op = reader["op"].ToString();

                                    Login_Form.UserName = name;
                                    Login_Form.UserOp = op;
                                    Login_Form.Password = password;

                                    MessageBox.Show($"登入成功，歡迎 {name}，您的操作權限是 {op}", "Log In Suceesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Clear_TextBox();

                                    MainForm mainForm = new MainForm();
                                    this.Hide();
                                    mainForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("帳號或密碼錯誤，請重新輸入", "Log In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Clear_TextBox();
                                    Account_get.Focus();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"異常錯誤：{ex.Message}");
                    Clear_TextBox();
                    Account_get.Focus();
                }
            }
        }

        private void Quit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Account_get_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Register_button_Click(object sender, EventArgs e)
        {
            Clear_TextBox();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
