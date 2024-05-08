namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.userName_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userOp_label = new System.Windows.Forms.Label();
            this.quit_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userName_label.Location = new System.Drawing.Point(3, 0);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(87, 20);
            this.userName_label.TabIndex = 0;
            this.userName_label.Text = "userName";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.userName_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.userOp_label, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // userOp_label
            // 
            this.userOp_label.AutoSize = true;
            this.userOp_label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userOp_label.Location = new System.Drawing.Point(3, 52);
            this.userOp_label.Name = "userOp_label";
            this.userOp_label.Size = new System.Drawing.Size(64, 20);
            this.userOp_label.TabIndex = 1;
            this.userOp_label.Text = "userOp";
            // 
            // quit_button
            // 
            this.quit_button.Location = new System.Drawing.Point(131, 418);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(115, 36);
            this.quit_button.TabIndex = 3;
            this.quit_button.Text = "Quit";
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.ControlBox = false;
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "大廳";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label userOp_label;
        private System.Windows.Forms.Button quit_button;
    }
}