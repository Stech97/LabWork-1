using System;
using System.Windows.Forms;

namespace LabWork_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            textBox1.Text = "0,0374";
            textBox2.Text = "-0,825";
            textBox3.Text = "16";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //Считывание значения X
            double X = double.Parse(textBox1.Text);
            //Вывод значения X в окно
            textBox5.Text += Environment.NewLine + "X=" + X.ToString();
            
            //Считывание значения Y
            double Y = double.Parse(textBox2.Text);
            //Вывод значения Y в окно
            textBox5.Text += Environment.NewLine + "Y=" + Y.ToString();
            
            //Считывание значения Z
            double Z = double.Parse(textBox3.Text);
            //Вывод значения Z в окно
            textBox5.Text += Environment.NewLine + "Z=" + Z.ToString();   
            
            //Вычисляем арифметическое выражение
            double a = Math.Sin(X + Y) * Math.Sin(X + Y) + 1;
            double b = Math.Abs(X - (2 * Y / (1 + X * X * Y * Y)));
            double c = Math.Pow(X, Math.Abs(Y));
            double d = Math.Cos(Math.Atan(1/Z)) * Math.Cos(Math.Atan(1 / Z));
            double V = a / b * c + d;

            //Выводим результат в окно
            textBox5.Text += Environment.NewLine + "Результат V=" + V.ToString();
        }
    }
}
