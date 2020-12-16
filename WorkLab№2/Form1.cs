using System;
using System.Windows.Forms;

namespace WorkLab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            textBox3.Text += "Результаты работы программы  ст.";

            //Считывание значения X
            double X = double.Parse(textBox1.Text);
            //Вывод значения X в окно
            textBox3.Text += Environment.NewLine + "При X=" + X.ToString();
            
            //Считывание значения Y
            double Y = double.Parse(textBox2.Text);
            //Вывод значения Y в окно
            textBox3.Text += Environment.NewLine + "При Y=" + Y.ToString();

            //Вычисление выражения

            double c;
           
            if ((X - Y) > 0)
            {
                var t = Math.Pow(X, 2.0) - Y;
                c = Math.Pow(t, 2.0) + Math.Cos(Y);
            }
            else
            {
                var t = Math.Pow(X, 2.0) - Y;
                c = Math.Pow(t, 2.0) + Math.Tan(Y);
                if ((X - Y) == 0)
                    c = Math.Pow(X, 4.0) + Math.Pow(Y, 2.0) + Math.Sin(Y);
            }

            //Выводим результат в окно
            textBox3.Text += Environment.NewLine + "Результат C=" + c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
    }
}
