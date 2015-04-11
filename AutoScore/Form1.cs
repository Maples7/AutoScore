using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScore
{
    public partial class AutoScore : Form
    {
        public AutoScore()
        {
            InitializeComponent();
        }

        int type = 1;
        int a, b, ans, totNum = 0, rightNum = 0, range = 10;
        bool isCheck = false;
        string op;
        Random rnd = new Random();

        private void radio10in_CheckedChanged(object sender, EventArgs e)
        {
            if (radio10in.Checked)
            {
                type = 1;
                range = 10;
            }
        }

        private void radio20in_CheckedChanged(object sender, EventArgs e)
        {
            if (radio20in.Checked)
            {
                type = 2;
                range = 20;
            }
        }

        private void radioMulti_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMulti.Checked)
            {
                type = 3;
                range = 10;
            }
        }

        private void autoShowNext_CheckedChanged(object sender, EventArgs e)
        {
            if (autoShowNext.Checked)
            {
                timer1.Enabled = true;
                timer1.Interval = 10000;
                shownext();
                if (autoShowAns.Checked)
                {
                    ansBox.Text = "" + ans;
                }
            }
            else
                timer1.Enabled = false;
        }

        private void butFaster_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 500)
                timer1.Interval -= 500;
            else
                MessageBox.Show("不能再快啦！让我歇会 >_<");
        }

        private void butSlower_Click(object sender, EventArgs e)
        {
            if (timer1.Interval < 60000)
                timer1.Interval += 500;
            else
                MessageBox.Show("不能再慢啦！已经慢到一分钟啦! >_<");
        }

        string checkop(int num)
        {
            if (num == 0)
            {
                ans = a + b;
                return "+";
            }
            else
            {
                ans = a - b;
                return "-";
            }
        }

        void checkType()
        {
            int c = rnd.Next(2);
            a = rnd.Next(range - 1) + 1;
            b = rnd.Next(range - 1) + 1;
            
            switch (type)
            {
                case 1:
                    op = checkop(c);
                    break;
                case 2:
                    op = checkop(c);
                    break;
                case 3:
                    op = "*";
                    ans = a * b;
                    break;
            }
        }

        void shownext()
        {
            checkType();
            firstNum.Text = a.ToString();
            secondNum.Text = b.ToString();
            oprater.Text = op;
            ansBox.Text = "";
            rightRate.Text = "" + rightNum + "/" + totNum;
            totNum++;
            ansBox.BackColor = Color.White;
            isCheck = false;
        }

        private void butNextOne_Click(object sender, EventArgs e)
        {
            checkAnsFuc();
            shownext();
            if (autoShowAns.Checked)
            {
                ansBox.Text = "" + ans;
            } 
        }

        void checkAnsFuc()
        {
            if (isCheck) return;
            if (ansBox.Text != "")
            {
                string userInput = ansBox.Text;
                int temp = int.Parse(userInput);
                if (temp == ans)
                {
                    rightNum++;
                    ansBox.BackColor = Color.MediumSpringGreen;
                }
                else
                {
                    ansBox.BackColor = Color.Red;
                }
                rightRate.Text = "" + rightNum + "/" + totNum;
                isCheck = true;
            }
        }

        private void checkAns_Click(object sender, EventArgs e)
        {
            checkAnsFuc();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            if (!autoShowAns.Checked)
            {
                checkAnsFuc();
            }

            shownext();

            if (autoShowAns.Checked)
            {
                ansBox.Text = "" + ans;
            }  
        }

        private void autoShowAns_CheckedChanged(object sender, EventArgs e)
        {
            if (autoShowAns.Checked)
            {
                lastAns.Visible = true;
                lastAns.Text = "您已开启自动显示答案";
                label3.Visible = false;
                rightRate.Visible = false;
                ansBox.Text = "" + ans;
            }
            else
            {
                totNum = 1; rightNum = 0;
                rightRate.Text = "" + rightNum + "/" + totNum;
                lastAns.Visible = false;
                label3.Visible = true;
                rightRate.Visible = true;
            }
        }
    }
}
