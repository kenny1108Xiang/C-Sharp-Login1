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

        private void MainForm_Load(object sender, EventArgs e)
        {
            string userName = Login_Form.UserName;
            string userOp = Login_Form.UserOp;
            userName_label.Text = "使用者名稱：" + userName;
            userOp_label.Text = "使用者權限：" + userOp;
        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
