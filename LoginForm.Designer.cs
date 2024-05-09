namespace WindowsFormsApp1
{
    partial class Login_Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Account_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Show_password = new System.Windows.Forms.Button();
            this.Hide_password = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Quit_button = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Password_get = new System.Windows.Forms.MaskedTextBox();
            this.Account_get = new System.Windows.Forms.MaskedTextBox();
            this.progressBar_Login = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Account_label
            // 
            this.Account_label.AutoSize = true;
            this.Account_label.Location = new System.Drawing.Point(3, 0);
            this.Account_label.Name = "Account_label";
            this.Account_label.Size = new System.Drawing.Size(44, 12);
            this.Account_label.TabIndex = 0;
            this.Account_label.Text = "Account";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(3, 71);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(48, 12);
            this.Password_label.TabIndex = 1;
            this.Password_label.Text = "Password";
            // 
            // Show_password
            // 
            this.Show_password.Location = new System.Drawing.Point(273, 246);
            this.Show_password.Name = "Show_password";
            this.Show_password.Size = new System.Drawing.Size(52, 23);
            this.Show_password.TabIndex = 4;
            this.Show_password.Text = "Show";
            this.Show_password.UseVisualStyleBackColor = true;
            this.Show_password.Click += new System.EventHandler(this.Show_password_Click);
            // 
            // Hide_password
            // 
            this.Hide_password.Location = new System.Drawing.Point(273, 246);
            this.Hide_password.Name = "Hide_password";
            this.Hide_password.Size = new System.Drawing.Size(52, 23);
            this.Hide_password.TabIndex = 5;
            this.Hide_password.Text = "Hide";
            this.Hide_password.UseVisualStyleBackColor = true;
            this.Hide_password.Visible = false;
            this.Hide_password.Click += new System.EventHandler(this.Hide_password_Click);
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(3, 3);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(115, 36);
            this.Login_button.TabIndex = 6;
            this.Login_button.Text = "Log In";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Quit_button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Login_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Register_button, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(119, 308);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(121, 128);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // Quit_button
            // 
            this.Quit_button.Location = new System.Drawing.Point(3, 87);
            this.Quit_button.Name = "Quit_button";
            this.Quit_button.Size = new System.Drawing.Size(115, 38);
            this.Quit_button.TabIndex = 7;
            this.Quit_button.Text = "Quit";
            this.Quit_button.UseVisualStyleBackColor = true;
            this.Quit_button.Click += new System.EventHandler(this.Quit_button_Click);
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(3, 45);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(115, 36);
            this.Register_button.TabIndex = 8;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Password_get, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Account_label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Password_label, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Account_get, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(100, 149);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.46428F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.53571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(167, 153);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // Password_get
            // 
            this.Password_get.Location = new System.Drawing.Point(3, 99);
            this.Password_get.Name = "Password_get";
            this.Password_get.Size = new System.Drawing.Size(161, 22);
            this.Password_get.TabIndex = 11;
            this.Password_get.UseSystemPasswordChar = true;
            this.Password_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Account_get_KeyPress);
            // 
            // Account_get
            // 
            this.Account_get.Location = new System.Drawing.Point(3, 24);
            this.Account_get.Name = "Account_get";
            this.Account_get.Size = new System.Drawing.Size(161, 22);
            this.Account_get.TabIndex = 10;
            this.Account_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Account_get_KeyPress);
            // 
            // progressBar_Login
            // 
            this.progressBar_Login.Enabled = false;
            this.progressBar_Login.Location = new System.Drawing.Point(122, 452);
            this.progressBar_Login.Name = "progressBar_Login";
            this.progressBar_Login.Size = new System.Drawing.Size(115, 23);
            this.progressBar_Login.TabIndex = 14;
            this.progressBar_Login.Visible = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.progressBar_Login);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Hide_password);
            this.Controls.Add(this.Show_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login System";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Account_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button Show_password;
        private System.Windows.Forms.Button Hide_password;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Quit_button;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MaskedTextBox Password_get;
        private System.Windows.Forms.MaskedTextBox Account_get;
        private System.Windows.Forms.ProgressBar progressBar_Login;
    }
}

