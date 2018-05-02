using System;
using System.Windows.Forms;

namespace tf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean haveCc = false;
        private Boolean haveFs = false;
        private Boolean haveKh = false;
        private Boolean haveYs = false;
        private Boolean haveFenshu = false;
        private Boolean haveXs = false;
        private int Xs = 0;
        private int max = 100;
        private int min = 0;
        private int num = 30;
        private int jg = 0;
        private String outputs = "";

        private void button1_Click(object sender, EventArgs e)
        {
            haveCc = checkBox1.Checked;
            haveFs = checkBox3.Checked;
            haveKh = checkBox2.Checked;
            haveYs = checkBox4.Checked;
            haveFenshu = checkBox5.Checked;
            haveXs = checkBox6.Checked;
            Xs = (int)numericUpDown1.Value;
            num = Convert.ToInt32(textBox5.Text);
            output();
        }

        private void output()
        {
            richTextBox1.Text = "";
            Random random = new Random();
            for (int i = 1; i <= num; i++)
            {
                float number_1 = random.Next(min, max);
                float number_2 = random.Next(min, max);
                float[] numbers = { number_1, number_2 };
                char[] chars = { '+', '-', 'x', '/' };
                if (haveXs)
                {
                    int flag = random.Next(0, 1);
                    numbers[flag] = numbers[flag] / 10;
                }
                if (haveCc)
                {
                    outputs += numbers[0] + chars[random.Next(0, 3)].ToString() + numbers[1] + "=\n";
                }
                else
                {
                    outputs += numbers[0] + chars[random.Next(0, 1)].ToString() + numbers[1] + "=\n";
                }
                richTextBox1.Text = outputs;
            }
        }
    }
}