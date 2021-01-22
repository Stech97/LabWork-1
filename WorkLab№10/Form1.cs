using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkLab_10
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        const int N = 18;
        double[] Mas = new double[N];

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < N; i++)
            {
                Mas[i] = 0.13 * Math.Pow(Mas[i], 3) - 2.5 * Mas[i] + 8;
                listBox2.Items.Add("Mas[" + Convert.ToString(i) + "] = " + Mas[i].ToString());
            }
        }
    }
}
