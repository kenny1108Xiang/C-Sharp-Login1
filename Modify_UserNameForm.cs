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
    public partial class Modify_UserNameForm : Form
    {
        public static string upDate_Name;
        private int Error_Count = 0;
        public Modify_UserNameForm()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            ModifyForm modifyForm = new ModifyForm();
            modifyForm.Show();
            this.Close();
        }

        private void Clear_TextBox()
        {
            this.Check_PassWord_get.Clear();
            this.upDate_UserName_get.Clear();
        }

        private void Error_Quit(int Error)
        {
            if (Error == 3) //輸入失敗三次 
            {
                MessageBox.Show("輸入失敗達三次，稍後再嘗試", "錯誤太多次", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ModifyForm modifyForm = new ModifyForm();
                modifyForm.Show();
                this.Close();
            }
        }

        private (int, string) Check_TextBox(string password, string name)
        {
            int count = 0;
            string emptyField = "";

            if (string.IsNullOrEmpty(password))
            {
                count++;
                emptyField = "密碼";
            }

            if (string.IsNullOrEmpty(name))
            {
                count++;
                emptyField = "使用者名稱";
            }

            if (count == 2)
            {
                // 如果两个字段都为空，直接返回 2
                return (2, "");
            }
            else if (count == 1)
            {
                return (1, emptyField);
            }
            else
            {
                return (0, "");
            }
        }

        
        private async void Modify_userName_button_Click(object sender, EventArgs e)
        { 
            string check_Password = Check_PassWord_get.Text;
            upDate_Name = upDate_UserName_get.Text;
            var Check_Result = Check_TextBox(check_Password, upDate_Name);

            if (Check_Result.Item1 == 2) //兩者皆為空
            {
                MessageBox.Show("請輸入密碼與新的使用者名稱", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox();
                return;
            }
            else if (Check_Result.Item1 == 1)
            {
                MessageBox.Show($"請輸入{Check_Result.Item2}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox();
                return;
            }
            else
            { 
                if (Login_Form.Password != check_Password) //輸入錯誤的密碼
                {
                    MessageBox.Show("密碼錯誤", "驗證失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear_TextBox();
                    Error_Count++;
                    Error_Quit(Error_Count); //確認錯誤是否達到三次
                    return;
                }
                else if (Login_Form.UserName == upDate_Name)
                {
                    MessageBox.Show("不可與上個名稱重複", "輸入相同名稱", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear_TextBox();
                    Error_Count++;
                    Error_Quit(Error_Count); //確認錯誤是否達到三次
                    return;
                }

                string connectionString = "Data Source=Data.db;Version=3;";
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        await connection.OpenAsync();

                        string updateQuery = "UPDATE Data SET name = @name WHERE password = @password";
                        using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@name", upDate_Name);
                            command.Parameters.AddWithValue("@password", check_Password);

                            int rowsAffected = await command.ExecuteNonQueryAsync();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("使用者名稱已成功更新", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("未更新使用者名稱", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"更新使用者名稱時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void Check_EnterData(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '\b') // 允許數字、大小寫英文與backspace
            {
                MessageBox.Show("只允許數字、大小寫英文", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // 取消输入
            }
        }
    }
}
