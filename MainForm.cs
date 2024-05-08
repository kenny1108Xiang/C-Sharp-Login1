using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void UpdateUserInfo()
        {
            userName_label.Text = "使用者名稱：" + Login_Form.UserName;
            userOp_label.Text = "使用者權限：" + Login_Form.UserOp;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateUserInfo();
        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Form loginForm = new Login_Form();
            loginForm.Show();
        }
    }
}
