using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace Binary_to_Decimal_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int number = int.Parse(textBox1.Text);
            string Base = Convert.ToString(number, 2);
            textBox2.Text = Base;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int number = int.Parse(textBox1.Text);
            string Base = Convert.ToString(number, 16);
            textBox2.Text = Base;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            int number = int.Parse(textBox1.Text);
            string Base = Convert.ToString(number, 8);
            textBox2.Text = Base;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.github.com/CristiiiSE",
                UseShellExecute = true
            };
            Process.Start(psInfo);

        }
    }
}
