namespace WindowsFormsApp1
{
    partial class Modify_UserNameForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Check_PassWord_get = new System.Windows.Forms.MaskedTextBox();
            this.upDate_UserName_get = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Modify_userName_button = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(139, 430);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 0;
            this.Cancel_Button.Text = "取消";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Check_PassWord_get
            // 
            this.Check_PassWord_get.Location = new System.Drawing.Point(103, 3);
            this.Check_PassWord_get.Name = "Check_PassWord_get";
            this.Check_PassWord_get.Size = new System.Drawing.Size(94, 22);
            this.Check_PassWord_get.TabIndex = 1;
            this.Check_PassWord_get.UseSystemPasswordChar = true;
            this.Check_PassWord_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_EnterData);
            // 
            // upDate_UserName_get
            // 
            this.upDate_UserName_get.Location = new System.Drawing.Point(103, 53);
            this.upDate_UserName_get.Name = "upDate_UserName_get";
            this.upDate_UserName_get.Size = new System.Drawing.Size(94, 22);
            this.upDate_UserName_get.TabIndex = 2;
            this.upDate_UserName_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_EnterData);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Check_PassWord_get, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.upDate_UserName_get, 1, 1);
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(85, 200);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 12);
            label1.TabIndex = 3;
            label1.Text = "輸入密碼";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 12);
            label2.TabIndex = 4;
            label2.Text = "更新使用者名稱";
            // 
            // Modify_userName_button
            // 
            this.Modify_userName_button.Location = new System.Drawing.Point(139, 319);
            this.Modify_userName_button.Name = "Modify_userName_button";
            this.Modify_userName_button.Size = new System.Drawing.Size(75, 23);
            this.Modify_userName_button.TabIndex = 4;
            this.Modify_userName_button.Text = "修改";
            this.Modify_userName_button.UseVisualStyleBackColor = true;
            this.Modify_userName_button.Click += new System.EventHandler(this.Modify_userName_button_Click);
            // 
            // Modify_UserNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.ControlBox = false;
            this.Controls.Add(this.Modify_userName_button);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Cancel_Button);
            this.Name = "Modify_UserNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改使用者名稱";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.MaskedTextBox Check_PassWord_get;
        private System.Windows.Forms.MaskedTextBox upDate_UserName_get;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Modify_userName_button;
    }
}