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
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void Modify_userName_Click(object sender, EventArgs e)
        {
            Modify_UserNameForm modify_UserNameForm = new Modify_UserNameForm();
            modify_UserNameForm.Show();
            this.Close();
        }

        private void Modify_password_Click(object sender, EventArgs e)
        {
            Modify_PasswordForm modify_PasswordForm = new Modify_PasswordForm();
            modify_PasswordForm.Show();
            this.Close();
        }
    }
}
