using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WorkLab_3
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            PointF[] points =
                {
                    new PointF(25,  65),
                    new PointF(85, 25),
                    new PointF(165, 65),
                    new PointF(135, 153),
                    new PointF(35,  153),
                    new PointF(25, 65)
            };

            g.DrawLines(new Pen(Color.Green, 4), points);
            
            g.FillEllipse(new SolidBrush(Color.Blue), new RectangleF(180, 180, 120, 80));


            PointF startPt = new PointF(180.0F, 80.0F);
            PointF control1Pt = new PointF(250.0F, 10.0F);
            PointF control2Pt = new PointF(400.0F, 250.0F);
            PointF endPt = new PointF(500.0F, 100.0F);

            PointF[] myBezierPoints =
            {
                startPt,
                control1Pt,
                control2Pt,
                endPt
            };


            g.DrawBeziers(new Pen(Color.Orange, 6), myBezierPoints);

            int xPos = 10;
            int yPos = 10;
            int width = 760;
            int height = 440;

            int startAngle = 10;
            int endAngle = 50;

            g.DrawPie(new Pen(Color.Red, 2), xPos, yPos, width, height, startAngle, endAngle);

            g.DrawRectangle(new Pen(Color.Black, 5), xPos, yPos, width, height);

            Pen myPen = new Pen(Color.Brown)
            {
                Width = 5,
                DashStyle = DashStyle.DashDotDot,
                StartCap = LineCap.Round,
                EndCap = LineCap.Round
            };
            g.DrawLine(myPen, 100, 400, 450, 400);
        }
    }
}