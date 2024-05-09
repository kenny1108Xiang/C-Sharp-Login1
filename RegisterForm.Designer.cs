namespace WindowsFormsApp1
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Back_to_Login_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkPassword_get = new System.Windows.Forms.MaskedTextBox();
            this.password_get = new System.Windows.Forms.MaskedTextBox();
            this.account_get = new System.Windows.Forms.MaskedTextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.account_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.name_get = new System.Windows.Forms.MaskedTextBox();
            this.Check_password_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back_to_Login_button
            // 
            this.Back_to_Login_button.Location = new System.Drawing.Point(146, 430);
            this.Back_to_Login_button.Name = "Back_to_Login_button";
            this.Back_to_Login_button.Size = new System.Drawing.Size(75, 23);
            this.Back_to_Login_button.TabIndex = 0;
            this.Back_to_Login_button.Text = "Back";
            this.Back_to_Login_button.UseVisualStyleBackColor = true;
            this.Back_to_Login_button.Click += new System.EventHandler(this.Back_to_Login_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63975F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.36024F));
            this.tableLayoutPanel1.Controls.Add(this.checkPassword_get, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.password_get, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.account_get, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.name_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.account_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.password_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.name_get, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Check_password_label, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(63, 150);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 188);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // checkPassword_get
            // 
            this.checkPassword_get.Location = new System.Drawing.Point(82, 138);
            this.checkPassword_get.Name = "checkPassword_get";
            this.checkPassword_get.Size = new System.Drawing.Size(125, 22);
            this.checkPassword_get.TabIndex = 7;
            this.checkPassword_get.UseSystemPasswordChar = true;
            this.checkPassword_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.account_get_KeyPress);
            // 
            // password_get
            // 
            this.password_get.Location = new System.Drawing.Point(82, 98);
            this.password_get.Name = "password_get";
            this.password_get.Size = new System.Drawing.Size(125, 22);
            this.password_get.TabIndex = 6;
            this.password_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.account_get_KeyPress);
            // 
            // account_get
            // 
            this.account_get.Location = new System.Drawing.Point(82, 54);
            this.account_get.Name = "account_get";
            this.account_get.Size = new System.Drawing.Size(125, 22);
            this.account_get.TabIndex = 5;
            this.account_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.account_get_KeyPress);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(3, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(32, 12);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // account_label
            // 
            this.account_label.AutoSize = true;
            this.account_label.Location = new System.Drawing.Point(3, 51);
            this.account_label.Name = "account_label";
            this.account_label.Size = new System.Drawing.Size(44, 12);
            this.account_label.TabIndex = 1;
            this.account_label.Text = "Account";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(3, 95);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(48, 12);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password";
            // 
            // name_get
            // 
            this.name_get.Location = new System.Drawing.Point(82, 3);
            this.name_get.Name = "name_get";
            this.name_get.Size = new System.Drawing.Size(125, 22);
            this.name_get.TabIndex = 4;
            this.name_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_get_KeyPress);
            // 
            // Check_password_label
            // 
            this.Check_password_label.AutoSize = true;
            this.Check_password_label.Location = new System.Drawing.Point(3, 135);
            this.Check_password_label.Name = "Check_password_label";
            this.Check_password_label.Size = new System.Drawing.Size(48, 24);
            this.Check_password_label.TabIndex = 3;
            this.Check_password_label.Text = "Check Password";
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(146, 373);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(75, 23);
            this.register_button.TabIndex = 2;
            this.register_button.Text = "Do Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(134, 476);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Back_to_Login_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_to_Login_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label account_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label Check_password_label;
        private System.Windows.Forms.MaskedTextBox checkPassword_get;
        private System.Windows.Forms.MaskedTextBox password_get;
        private System.Windows.Forms.MaskedTextBox account_get;
        private System.Windows.Forms.MaskedTextBox name_get;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}