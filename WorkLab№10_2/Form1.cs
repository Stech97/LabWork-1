using System;
using System.Windows.Forms;

namespace WorkLab_10_2
{
    public partial class Form1 : Form
    {
        double[,] b = new double[10, 10];
        int i, j;


        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;
            Random rand = new Random();

            for (i = 0; i < 10; i++)
                for (j = 0; j < 10; j++)
                    b[i, j] = rand.Next(-100, -50);
            for (i = 0; i < 10; i++)
                for (j = 0; j < 10; j++)
                    dataGridView1.Rows[i].Cells[j].Value = b[i, j].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double S = 0;

            for (i = 0; i < 10; i++)
                S += b[i, i];
            if (S > 10)
                for (i = 0; i < 10; i++)
                    for (j = 0; j < 10; j++)
                        b[i, j] = b[i, j] + 13.5;
            else
                for (i = 0; i < 10; i++)
                    for (j = 0; j < 10; j++)
                        b[i, j] = Math.Pow(b[i, j], 2.0) - 1.5;

            for (i = 0; i < 10; i++)
                for (j = 0; j < 10; j++)
                    dataGridView1.Rows[i].Cells[j].Value = b[i, j].ToString();
            textBox1.Text = S.ToString();
        }
    }
}
