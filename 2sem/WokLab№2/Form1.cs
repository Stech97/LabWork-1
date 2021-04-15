using System;
using System.Windows.Forms;

namespace WokLab_2
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            var seriesSin = new System.Windows.Forms.DataVisualization.Charting.Series("y=1.02*x^3*tg(10.2-1.25*x)");
            var seriesCos = new System.Windows.Forms.DataVisualization.Charting.Series("y=40*x^2");
            seriesSin.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            seriesCos.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            seriesSin.BorderWidth = 5;
            seriesCos.BorderWidth = 5;
            chart1.Series.Add(seriesSin);
            chart1.Series.Add(seriesCos);
        }

        private void Execute_Click(object sender, EventArgs e)
        {
           
            double Xmin;
            double Xmax;
            double Step;

            try
            {
                Xmin = double.Parse(textBoxXmin.Text);
            }
            catch (FormatException)
            {
                Xmin = double.Parse(textBoxXmin.Text.Replace(".", ","));
            }

            try
            {
                Xmax = double.Parse(textBoxXmax.Text);
            }
            catch (FormatException)
            {
                Xmax = double.Parse(textBoxXmax.Text.Replace(".", ","));
            }

            try
            {
                Step = double.Parse(textBoxStep.Text);
            }
            catch (FormatException)
            {
                Step = double.Parse(textBoxStep.Text.Replace(".", ","));
            }

            // Количество точек графика
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            // Массив значений X – общий для обоих графиков
            double[] x = new double[count];
            // Два массива Y – по одному для каждого графика
            double[] y1 = new double[count];
            double[] y2 = new double[count];
            // Расчитываем точки для графиков функции
            for (int i = 0; i < count; i++)
            {
                // Вычисляем значение X
                x[i] = Xmin + Step * i;
                double grad = 10.2 - (1.25 * x[i]);
                // Вычисляем значение функций в точке X
                y1[i] = 1.02 * Math.Pow(x[i], 3.0) * Math.Tan(grad);
                y2[i] = 40 * Math.Pow(x[i], 2.0);
            }
            // Настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;

            // Определяем шаг сетки
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            // Добавляем вычисленные значения в графики
            chart1.Series[0].Points.DataBindXY(x, y1);
            chart1.Series[1].Points.DataBindXY(x, y2);
        }

    }
}
