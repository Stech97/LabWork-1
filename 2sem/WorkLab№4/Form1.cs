using System;
using System.Drawing;
using System.Windows.Forms;

namespace WorkLab_4
{
    public partial class Form1 : Form
    {
        private int ClientWidth;

        private int R;
        private int XBody;
        private int XRightTop;
        private int XRightBottom;
        private int XLeftTop;
        private int XLeftBottom;
        private int El;

        private Pen pen = new Pen(Color.DarkRed, 3);

        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientWidth = ClientSize.Width;

            R = 50;
            XBody = 75;
            XRightTop = 75;
            XRightBottom = 120;

            XLeftTop = 40;
            XLeftBottom = 75;
            
            El = 50;

            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ClientWidth = ClientSize.Width;

            Graphics myGraphics = e.Graphics;

            myGraphics.DrawLine(pen, XBody, 100, XBody, 170);

            myGraphics.DrawLine(pen, XRightTop, 170, XRightBottom, 200);
            myGraphics.DrawLine(pen, XRightTop, 120, XRightBottom, 150);

            myGraphics.DrawLine(pen, XLeftTop, 150, XLeftBottom, 120);
            myGraphics.DrawLine(pen, XLeftTop, 200, XLeftBottom, 170);

            myGraphics.DrawEllipse(pen, El, 50, R, R);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (XRightBottom >= ClientWidth)
            {
                XBody = 75;
                XRightTop = 75;
                XRightBottom = 120;

                XLeftTop = 40;
                XLeftBottom = 75;

                El = 50;
            }
            

            XBody += 5;

            XRightTop += 5;
            XRightBottom += 5;
            
            XLeftTop += 5;
            XLeftBottom += 5;

            El += 5;

            Invalidate();
        }
    }
}
