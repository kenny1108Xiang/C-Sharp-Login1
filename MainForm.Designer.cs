using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.LogOut_button = new System.Windows.Forms.Button();
            this.main_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.answer_get = new System.Windows.Forms.MaskedTextBox();
            this.answer_label = new System.Windows.Forms.Label();
            this.guessData_get = new System.Windows.Forms.Button();
            this.commit = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guess_count_get = new System.Windows.Forms.MaskedTextBox();
            this.minNum_get = new System.Windows.Forms.MaskedTextBox();
            this.maxNum_get = new System.Windows.Forms.MaskedTextBox();
            this.minNum_label = new System.Windows.Forms.Label();
            this.maxNum_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.result_num = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.commit2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.count_get = new System.Windows.Forms.MaskedTextBox();
            this.maxNum_get2 = new System.Windows.Forms.MaskedTextBox();
            this.minNum_label2 = new System.Windows.Forms.Label();
            this.minNum_label3 = new System.Windows.Forms.Label();
            this.minNum_get2 = new System.Windows.Forms.MaskedTextBox();
            this.count_label = new System.Windows.Forms.Label();
            this.Setting_tabPage = new System.Windows.Forms.TabPage();
            this.Modify_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.main_tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.Setting_tabPage.SuspendLayout();
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
            this.quit_button.Location = new System.Drawing.Point(126, 463);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(115, 36);
            this.quit_button.TabIndex = 3;
            this.quit_button.Text = "Quit";
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // LogOut_button
            // 
            this.LogOut_button.Location = new System.Drawing.Point(126, 421);
            this.LogOut_button.Name = "LogOut_button";
            this.LogOut_button.Size = new System.Drawing.Size(115, 36);
            this.LogOut_button.TabIndex = 4;
            this.LogOut_button.Text = "Log Out";
            this.LogOut_button.UseVisualStyleBackColor = true;
            this.LogOut_button.Click += new System.EventHandler(this.LogOut_button_Click);
            // 
            // main_tabControl
            // 
            this.main_tabControl.Controls.Add(this.tabPage1);
            this.main_tabControl.Controls.Add(this.tabPage2);
            this.main_tabControl.Controls.Add(this.Setting_tabPage);
            this.main_tabControl.Location = new System.Drawing.Point(40, 131);
            this.main_tabControl.Name = "main_tabControl";
            this.main_tabControl.SelectedIndex = 0;
            this.main_tabControl.Size = new System.Drawing.Size(313, 284);
            this.main_tabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.answer_get);
            this.tabPage1.Controls.Add(this.answer_label);
            this.tabPage1.Controls.Add(this.guessData_get);
            this.tabPage1.Controls.Add(this.commit);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(305, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "猜數字遊戲";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // answer_get
            // 
            this.answer_get.Enabled = false;
            this.answer_get.Location = new System.Drawing.Point(95, 170);
            this.answer_get.Name = "answer_get";
            this.answer_get.ReadOnly = true;
            this.answer_get.Size = new System.Drawing.Size(72, 22);
            this.answer_get.TabIndex = 0;
            // 
            // answer_label
            // 
            this.answer_label.AutoSize = true;
            this.answer_label.Enabled = false;
            this.answer_label.Location = new System.Drawing.Point(115, 155);
            this.answer_label.Name = "answer_label";
            this.answer_label.Size = new System.Drawing.Size(29, 12);
            this.answer_label.TabIndex = 7;
            this.answer_label.Text = "答案";
            // 
            // guessData_get
            // 
            this.guessData_get.Location = new System.Drawing.Point(81, 118);
            this.guessData_get.Name = "guessData_get";
            this.guessData_get.Size = new System.Drawing.Size(101, 34);
            this.guessData_get.TabIndex = 9;
            this.guessData_get.Text = "輸入猜測資料";
            this.guessData_get.UseVisualStyleBackColor = true;
            this.guessData_get.Click += new System.EventHandler(this.guessData_get_Click);
            // 
            // commit
            // 
            this.commit.Enabled = false;
            this.commit.Location = new System.Drawing.Point(95, 229);
            this.commit.Name = "commit";
            this.commit.Size = new System.Drawing.Size(75, 23);
            this.commit.TabIndex = 7;
            this.commit.Text = "送出";
            this.commit.UseVisualStyleBackColor = true;
            this.commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.guess_count_get, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.minNum_get, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.maxNum_get, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.minNum_label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.maxNum_label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(31, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.875F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.125F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 93);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // guess_count_get
            // 
            this.guess_count_get.Location = new System.Drawing.Point(103, 67);
            this.guess_count_get.Name = "guess_count_get";
            this.guess_count_get.Size = new System.Drawing.Size(94, 22);
            this.guess_count_get.TabIndex = 6;
            this.guess_count_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minNum_get_KeyPress);
            // 
            // minNum_get
            // 
            this.minNum_get.Location = new System.Drawing.Point(103, 3);
            this.minNum_get.Name = "minNum_get";
            this.minNum_get.Size = new System.Drawing.Size(94, 22);
            this.minNum_get.TabIndex = 1;
            this.minNum_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minNum_get_KeyPress);
            // 
            // maxNum_get
            // 
            this.maxNum_get.Location = new System.Drawing.Point(103, 33);
            this.maxNum_get.Name = "maxNum_get";
            this.maxNum_get.Size = new System.Drawing.Size(94, 22);
            this.maxNum_get.TabIndex = 2;
            this.maxNum_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minNum_get_KeyPress);
            // 
            // minNum_label
            // 
            this.minNum_label.AutoSize = true;
            this.minNum_label.Location = new System.Drawing.Point(3, 0);
            this.minNum_label.Name = "minNum_label";
            this.minNum_label.Size = new System.Drawing.Size(53, 12);
            this.minNum_label.TabIndex = 3;
            this.minNum_label.Text = "最小數字";
            // 
            // maxNum_label
            // 
            this.maxNum_label.AutoSize = true;
            this.maxNum_label.Location = new System.Drawing.Point(3, 30);
            this.maxNum_label.Name = "maxNum_label";
            this.maxNum_label.Size = new System.Drawing.Size(53, 12);
            this.maxNum_label.TabIndex = 4;
            this.maxNum_label.Text = "最大數字";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "猜測次數";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.result_num);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.commit2);
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(305, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "抽數字";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // result_num
            // 
            this.result_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_num.Enabled = false;
            this.result_num.Location = new System.Drawing.Point(82, 201);
            this.result_num.Multiline = true;
            this.result_num.Name = "result_num";
            this.result_num.ReadOnly = true;
            this.result_num.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result_num.Size = new System.Drawing.Size(115, 43);
            this.result_num.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "不排序<預設>",
            "大排到小",
            "小排到大"});
            this.comboBox1.Location = new System.Drawing.Point(82, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // commit2
            // 
            this.commit2.Location = new System.Drawing.Point(102, 146);
            this.commit2.Name = "commit2";
            this.commit2.Size = new System.Drawing.Size(75, 23);
            this.commit2.TabIndex = 2;
            this.commit2.Text = "抽取";
            this.commit2.UseVisualStyleBackColor = true;
            this.commit2.Click += new System.EventHandler(this.commit2_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.count_get, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.maxNum_get2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.minNum_label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.minNum_label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.minNum_get2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.count_label, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(43, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 122);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // count_get
            // 
            this.count_get.Location = new System.Drawing.Point(103, 91);
            this.count_get.Name = "count_get";
            this.count_get.Size = new System.Drawing.Size(94, 22);
            this.count_get.TabIndex = 5;
            this.count_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minNum_get2_KeyPress);
            // 
            // maxNum_get2
            // 
            this.maxNum_get2.Location = new System.Drawing.Point(103, 47);
            this.maxNum_get2.Name = "maxNum_get2";
            this.maxNum_get2.Size = new System.Drawing.Size(94, 22);
            this.maxNum_get2.TabIndex = 3;
            this.maxNum_get2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minNum_get2_KeyPress);
            // 
            // minNum_label2
            // 
            this.minNum_label2.AutoSize = true;
            this.minNum_label2.Location = new System.Drawing.Point(3, 0);
            this.minNum_label2.Name = "minNum_label2";
            this.minNum_label2.Size = new System.Drawing.Size(53, 12);
            this.minNum_label2.TabIndex = 0;
            this.minNum_label2.Text = "最小數字";
            // 
            // minNum_label3
            // 
            this.minNum_label3.AutoSize = true;
            this.minNum_label3.Location = new System.Drawing.Point(3, 44);
            this.minNum_label3.Name = "minNum_label3";
            this.minNum_label3.Size = new System.Drawing.Size(53, 12);
            this.minNum_label3.TabIndex = 1;
            this.minNum_label3.Text = "最大數字";
            // 
            // minNum_get2
            // 
            this.minNum_get2.Location = new System.Drawing.Point(103, 3);
            this.minNum_get2.Name = "minNum_get2";
            this.minNum_get2.Size = new System.Drawing.Size(94, 22);
            this.minNum_get2.TabIndex = 2;
            this.minNum_get2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minNum_get2_KeyPress);
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(3, 88);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(53, 12);
            this.count_label.TabIndex = 4;
            this.count_label.Text = "抽取個數";
            // 
            // Setting_tabPage
            // 
            this.Setting_tabPage.Controls.Add(this.Modify_button);
            this.Setting_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Setting_tabPage.Name = "Setting_tabPage";
            this.Setting_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Setting_tabPage.Size = new System.Drawing.Size(305, 258);
            this.Setting_tabPage.TabIndex = 2;
            this.Setting_tabPage.Text = "帳號設定";
            this.Setting_tabPage.UseVisualStyleBackColor = true;
            // 
            // Modify_button
            // 
            this.Modify_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modify_button.Location = new System.Drawing.Point(102, 207);
            this.Modify_button.Name = "Modify_button";
            this.Modify_button.Size = new System.Drawing.Size(75, 23);
            this.Modify_button.TabIndex = 0;
            this.Modify_button.Text = "修改";
            this.Modify_button.UseVisualStyleBackColor = true;
            this.Modify_button.Click += new System.EventHandler(this.Modify_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.ControlBox = false;
            this.Controls.Add(this.main_tabControl);
            this.Controls.Add(this.LogOut_button);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "大廳";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.main_tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.Setting_tabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label userOp_label;
        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.Button LogOut_button;
        private System.Windows.Forms.TabControl main_tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label maxNum_label;
        private System.Windows.Forms.MaskedTextBox minNum_get;
        private System.Windows.Forms.MaskedTextBox maxNum_get;
        private System.Windows.Forms.Label minNum_label;
        private System.Windows.Forms.Button commit;
        private System.Windows.Forms.Label answer_label;
        private System.Windows.Forms.MaskedTextBox answer_get;
        private System.Windows.Forms.Button guessData_get;
        private System.Windows.Forms.MaskedTextBox guess_count_get;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.MaskedTextBox maxNum_get2;
        private System.Windows.Forms.Label minNum_label2;
        private System.Windows.Forms.Label minNum_label3;
        private System.Windows.Forms.MaskedTextBox minNum_get2;
        private System.Windows.Forms.MaskedTextBox count_get;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.Button commit2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox result_num;
        private TabPage Setting_tabPage;
        private System.Windows.Forms.Button Modify_button;
    }
}