using System;
using System.Windows.Forms;

namespace factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);

            // n! = n * (n - 1) * (n - 2) * ... 2 * 1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = (Factorial(Convert.ToInt32(textBox1.Text))).ToString();
        }
    }
}
