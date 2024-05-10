namespace WindowsFormsApp1
{
    partial class Modify_PasswordForm
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
            this.Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Original_Password_label = new System.Windows.Forms.Label();
            this.New_Password_label = new System.Windows.Forms.Label();
            this.NewCheck_Password_label = new System.Windows.Forms.Label();
            this.Original_Password_get = new System.Windows.Forms.MaskedTextBox();
            this.New_Password_get = new System.Windows.Forms.MaskedTextBox();
            this.NewCheck_Password_get = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(139, 430);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.NewCheck_Password_get, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.New_Password_get, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Original_Password_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.New_Password_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NewCheck_Password_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Original_Password_get, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(85, 200);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Original_Password_label
            // 
            this.Original_Password_label.AutoSize = true;
            this.Original_Password_label.Location = new System.Drawing.Point(3, 0);
            this.Original_Password_label.Name = "Original_Password_label";
            this.Original_Password_label.Size = new System.Drawing.Size(41, 12);
            this.Original_Password_label.TabIndex = 0;
            this.Original_Password_label.Text = "原密碼";
            // 
            // New_Password_label
            // 
            this.New_Password_label.AutoSize = true;
            this.New_Password_label.Location = new System.Drawing.Point(3, 32);
            this.New_Password_label.Name = "New_Password_label";
            this.New_Password_label.Size = new System.Drawing.Size(41, 12);
            this.New_Password_label.TabIndex = 1;
            this.New_Password_label.Text = "新密碼";
            // 
            // NewCheck_Password_label
            // 
            this.NewCheck_Password_label.AutoSize = true;
            this.NewCheck_Password_label.Location = new System.Drawing.Point(3, 64);
            this.NewCheck_Password_label.Name = "NewCheck_Password_label";
            this.NewCheck_Password_label.Size = new System.Drawing.Size(53, 12);
            this.NewCheck_Password_label.TabIndex = 2;
            this.NewCheck_Password_label.Text = "確認密碼";
            // 
            // Original_Password_get
            // 
            this.Original_Password_get.Location = new System.Drawing.Point(103, 3);
            this.Original_Password_get.Name = "Original_Password_get";
            this.Original_Password_get.Size = new System.Drawing.Size(94, 22);
            this.Original_Password_get.TabIndex = 3;
            this.Original_Password_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Check);
            // 
            // New_Password_get
            // 
            this.New_Password_get.Location = new System.Drawing.Point(103, 35);
            this.New_Password_get.Name = "New_Password_get";
            this.New_Password_get.Size = new System.Drawing.Size(94, 22);
            this.New_Password_get.TabIndex = 4;
            this.New_Password_get.UseSystemPasswordChar = true;
            this.New_Password_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Check);
            // 
            // NewCheck_Password_get
            // 
            this.NewCheck_Password_get.Location = new System.Drawing.Point(103, 67);
            this.NewCheck_Password_get.Name = "NewCheck_Password_get";
            this.NewCheck_Password_get.Size = new System.Drawing.Size(94, 22);
            this.NewCheck_Password_get.TabIndex = 5;
            this.NewCheck_Password_get.UseSystemPasswordChar = true;
            this.NewCheck_Password_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Check);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modify_PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Cancel);
            this.Name = "Modify_PasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密碼";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox NewCheck_Password_get;
        private System.Windows.Forms.MaskedTextBox New_Password_get;
        private System.Windows.Forms.Label Original_Password_label;
        private System.Windows.Forms.Label New_Password_label;
        private System.Windows.Forms.Label NewCheck_Password_label;
        private System.Windows.Forms.MaskedTextBox Original_Password_get;
        private System.Windows.Forms.Button button1;
    }
}