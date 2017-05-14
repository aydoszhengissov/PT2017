using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class Form1 : Form
    {
        int width, height;
        float startAngle = -90.0F;
        float sweepAngle = 0.0F;

        Bitmap bmp;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            width = pictureBox1.Width;
            height = pictureBox1.Height;
            bmp = new Bitmap(width + 1, height + 1);
            g = Graphics.FromImage(bmp);
            g.DrawEllipse(new Pen(Color.Black), 0, 0, width, height);
            pictureBox1.Image = bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, width, height);
            sweepAngle += 6.0F;
            g.FillPie(new SolidBrush(Color.Red), rect, startAngle, sweepAngle);
            Refresh();
        }
    }
}