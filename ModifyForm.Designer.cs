namespace WindowsFormsApp1
{
    partial class ModifyForm
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
            this.Back = new System.Windows.Forms.Button();
            this.Modify_userName = new System.Windows.Forms.Button();
            this.Modify_password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(140, 402);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Modify_userName
            // 
            this.Modify_userName.Location = new System.Drawing.Point(117, 197);
            this.Modify_userName.Name = "Modify_userName";
            this.Modify_userName.Size = new System.Drawing.Size(121, 23);
            this.Modify_userName.TabIndex = 1;
            this.Modify_userName.Text = "修改使用者名稱";
            this.Modify_userName.UseVisualStyleBackColor = true;
            this.Modify_userName.Click += new System.EventHandler(this.Modify_userName_Click);
            // 
            // Modify_password
            // 
            this.Modify_password.Location = new System.Drawing.Point(117, 235);
            this.Modify_password.Name = "Modify_password";
            this.Modify_password.Size = new System.Drawing.Size(121, 23);
            this.Modify_password.TabIndex = 2;
            this.Modify_password.Text = "修改使用者密碼";
            this.Modify_password.UseVisualStyleBackColor = true;
            this.Modify_password.Click += new System.EventHandler(this.Modify_password_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.ControlBox = false;
            this.Controls.Add(this.Modify_password);
            this.Controls.Add(this.Modify_userName);
            this.Controls.Add(this.Back);
            this.Name = "ModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改系統";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Modify_userName;
        private System.Windows.Forms.Button Modify_password;
    }
}