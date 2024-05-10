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
    public partial class Modify_PasswordForm : Form
    {
        public Modify_PasswordForm()
        {
            InitializeComponent();
        }

        private void TextBox_Check(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '\b') // 允許數字、大小寫英文與backspace
            {
                MessageBox.Show("只允許數字、大小寫英文", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // 取消输入
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ModifyForm modifyForm = new ModifyForm();
            modifyForm.Show();
            this.Close();
        }
        private void Clear_TextBox()
        {
            Original_Password_get.Clear();
            New_Password_get.Clear();
            NewCheck_Password_get.Clear();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string Original_Password = Original_Password_get.Text;
            string New_Password = New_Password_get.Text;
            string NewCheck_Password = NewCheck_Password_get.Text;
            if (Original_Password.Length == 0 || New_Password.Length == 0 || NewCheck_Password.Length == 0)
            {
                MessageBox.Show("任一欄位不可為空", "未輸入", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox();
                return;
            }
            else if (Original_Password != Login_Form.Password)
            {
                MessageBox.Show("原密碼輸入錯誤", "驗證失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox();
                return;
            }
            else if (New_Password != NewCheck_Password)
            {
                MessageBox.Show("兩次密碼不一致", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox();
                return;
            }
            else if (Original_Password == New_Password)
            {
                MessageBox.Show("新密碼不可與原密碼相同", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox();
                return;
            }

            string connectionString = "Data Source=Data.db;Version=3;";
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string updateQuery = "UPDATE Data SET password = @password WHERE name = @name";
                    using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@password", New_Password);
                        command.Parameters.AddWithValue("@name", Login_Form.UserName);

                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("密碼修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login_Form.Password = New_Password;
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Close();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("無法修改密碼", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Close();
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改密碼時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
