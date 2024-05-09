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
        private int guess_answer;
        private int count;
        private int user_answer;
        
        public MainForm()
        {
            InitializeComponent();
            commit2.Click += commit2_Click;
        }

        public void UpdateUserInfo()
        {
            userName_label.Text = "使用者名稱：" + Login_Form.UserName;
            userOp_label.Text = "使用者權限：" + Login_Form.UserOp;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateUserInfo();
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            result_num.AutoSize = false;
            result_num.MaximumSize = new Size(200, 0);
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

        private void Clear_TextBox()
        {
            minNum_get.Clear();
            maxNum_get.Clear();
            guess_count_get.Clear();
        }

        private void Clear_TextBox1()
        {
            minNum_get2.Clear();
            maxNum_get2.Clear();
            count_get.Clear();
        }

        private void minNum_get_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // 允許數字與backspace
            {
                MessageBox.Show("只允許輸入數字", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // 取消输入
            }
        }

        private void guessData_get_Click(object sender, EventArgs e)
        {
            int minNum, maxNum;
            try
            {
                minNum = int.Parse(minNum_get.Text);
                maxNum = int.Parse(maxNum_get.Text);
                count = int.Parse(guess_count_get.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"輸入時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox();
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"輸入的數字太大或太小：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox();
                return;
            }

            if (minNum >= maxNum || count <= 0 || minNum <=0 || maxNum <= 0)
            {
                MessageBox.Show("輸入的範圍值有誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox();
                return;
            }
            else if (maxNum - minNum + 1 == count)
            {
                MessageBox.Show("輸入次數不可為範圍內的總數量", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox();
                return;
            }

            int seed = (int)DateTime.Now.Ticks;
            Random random = new Random(seed);
            
            guess_answer = random.Next(minNum, maxNum + 1);
            tableLayoutPanel2.Enabled = false;
            guessData_get.Enabled = false;
            answer_get.Enabled = true;
            commit.Enabled = true;
            answer_label.Enabled = true;
            this.tabPage2.Parent = null;
            MessageBox.Show("開始作答", "輸入成功");
        }

        private void commit_Click(object sender, EventArgs e)
        {
            user_answer = int.Parse(answer_get.Text);
            if (user_answer == guess_answer)
            {
                MessageBox.Show("你答對了!", "正確");
                answer_get.Clear();
                tableLayoutPanel2.Enabled = true;
                guessData_get.Enabled = true;
                answer_get.Enabled = false;
                commit.Enabled = false;
                answer_label.Enabled = false;
                Clear_TextBox();
                answer_get.Clear();
                this.tabPage2.Parent = this.main_tabControl;
                return;
            }
            else
            {
                count--;
                if (count == 0)
                {
                    MessageBox.Show($"機會結束，正確答案為{guess_answer}", "結束");
                    tableLayoutPanel2.Enabled = true;
                    guessData_get.Enabled = true;
                    answer_get.Enabled = false;
                    commit.Enabled = false;
                    answer_label.Enabled = false;
                    Clear_TextBox();
                    answer_get.Clear();
                    this.tabPage2.Parent = this.main_tabControl;
                    return;
                }
                else
                {
                    if (guess_answer > user_answer)
                    {
                        MessageBox.Show($"答案再大一點，剩下{count}次", "答錯");
                    }
                    else
                    {
                        MessageBox.Show($"答案再小一點，剩下{count}次", "答錯");
                    }
                    return;
                }
            }
        }

        private void minNum_get2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // 允許數字與backspace
            {
                MessageBox.Show("只允許輸入數字", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // 取消输入
            }
        }
        private List<int> randomNumbers = new List<int>();
        private void commit2_Click(object sender, EventArgs e)
        {
            // 清空 randomNumbers 列表，以便重新抽取新的隨機數字
            randomNumbers.Clear();


            // 其餘部分保持不變
            int minNum, maxNum, count;
            try
            {
                minNum = int.Parse(minNum_get2.Text);
                maxNum = int.Parse(maxNum_get2.Text);
                count = int.Parse(count_get.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"輸入時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox1();
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"輸入的數字太大或太小：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox1();
                return;
            }

            if (minNum >= maxNum || count <= 0 || (minNum <= 0 || maxNum <= 0))
            {
                MessageBox.Show("輸入的範圍值有誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox1();
                return;
            }
            else if (maxNum - minNum + 1 <= count)
            {
                MessageBox.Show("抽取次數不可為範圍內的總數量", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_TextBox1();
                return;
            }

            Random random = new Random();

            while (randomNumbers.Count < count)
            {
                int randomNumber = random.Next(minNum, maxNum + 1);

                if (!randomNumbers.Contains(randomNumber)) // 不重複數字
                {
                    randomNumbers.Add(randomNumber);
                }
            }

            // 排序和顯示結果的部分不變
            int selectedIndex = comboBox1.SelectedIndex;
            if (selectedIndex == 1)
            {
                randomNumbers.Sort((a, b) => b.CompareTo(a));
            }
            else if (selectedIndex == 2)
            {
                randomNumbers.Sort();
            }

            result_num.Visible = true;  
            result_num.Text = $"{minNum}~{maxNum}抽{count}個[" + string.Join(", ", randomNumbers) + "]";
            
        }

    }
}
