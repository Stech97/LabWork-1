using System;
using System.Windows.Forms;

namespace WorkLab_3
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, System.EventArgs e)
        {
            // Считывание начальных данных
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            textBox6.Text = "Работу выполлнил ст. " + Environment.NewLine;

            // Цикл для табулирования функции
            double x = x0;
            while (x <= xk )
            {
                double y = 0.1 * a * Math.Pow(x, 3.0) * Math.Tan(a - b * x);
                x += dx;
                textBox6.Text += "x=" + Convert.ToString(x) +"; y=" + Convert.ToString(y) + Environment.NewLine;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
