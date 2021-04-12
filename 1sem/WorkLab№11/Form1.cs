using System;
using System.Drawing;
using System.Windows.Forms;

namespace WorkLab_11
{
    public partial class Form1 : Form
    {
        public Form1() =>  InitializeComponent();

        private void panel1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                Button button = new Button
                {
                    Parent = panel1,
                    Size = new Size(100, 30),
                    Location = new Point(i * 120, (i+1)*25),
                    Text = $"{i+1} кнопка"
                };
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                TextBox textBox = new TextBox
                {
                    Parent = this,
                    Size = new Size(120,20),
                    Location = new Point(i*150, 150 + i*20),
                    Text = $"{i+1} поле ввода"
                };
            }
        }
    }
}
