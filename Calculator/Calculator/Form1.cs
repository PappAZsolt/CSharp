using Microsoft.VisualBasic.Devices;
using System.Formats.Asn1;

namespace Calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox.Text += 9;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                num1 = float.Parse(textBox.Text);
                textBox.Clear();
                textBox.Focus();
                count = 2;
            }

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                num1 = float.Parse(textBox.Text);
                textBox.Clear();
                textBox.Focus();
                count = 1;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            count = 0;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                num1 = float.Parse(textBox.Text);
                textBox.Clear();
                textBox.Focus();
                count = 3;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                num1 = float.Parse(textBox.Text);
                textBox.Clear();
                textBox.Focus();
                count = 4;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox.Text += 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            int c = textBox.TextLength;
            int flag = 0;
            string text = textBox.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ",")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox.Text = textBox.Text + ",";
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                num1 = float.Parse(textBox.Text);
                textBox.Clear();
                textBox.Focus();
                count = 5;
            }
        }

        public void compute(int count)
        {
            switch(count)
            {
                case 1:
                    ans = num1 - float.Parse(textBox.Text);
                    textBox.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(textBox.Text);
                    textBox.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox.Text);
                    textBox.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox.Text);
                    textBox.Text = ans.ToString();
                    break;
                case 5:
                    ans = (float)Math.Sqrt(num1);
                    textBox.Text = ans.ToString();
                    break;
                default:
                    break;
                    
            }
        }
    }
}