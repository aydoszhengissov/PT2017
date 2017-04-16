using Paint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Drawer drawer;

        public Form1()
        {
            InitializeComponent();
            drawer = new Drawer(pictureBox1);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawer.ok = true;
            drawer.prev = e.Location;

            if (drawer.shape == Drawer.Shape.Fill)
                drawer.fill(e.Location);

            if (e.Location != trackBar1.Location && trackBar1.Visible)
                trackBar1.Hide();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawer.ok)
                drawer.Draw(e.Location);

            pictureBox1.Refresh();
            mouseLocationLabel.Text = string.Format("X:{0},Y:{1}", e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawer.ok = false;
            drawer.SaveLastPath();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG Files (*jpg)| *.jpg| PNG Files (*png)| *.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                drawer.SaveImage(saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                drawer.OpenImage(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawer.shape = Drawer.Shape.Pencil;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawer.shape = Drawer.Shape.Line;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                drawer.pen = new Pen(dlg.Color);
                drawer.pen.Width = trackBar1.Value;
                drawer.raser.Width = trackBar1.Value;
            }
            changeImgColor(dlg.Color);
        }
        public void changeImgColor(Color color)
        {
            Bitmap bmp = new Bitmap(30, 30);
            Graphics gBmp = Graphics.FromImage(bmp);
            gBmp.FillEllipse(new SolidBrush(color), 0, 0, 30, 30);
            toolStripButton1.Image = bmp;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            drawer.shape = Drawer.Shape.Pencil;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            drawer.shape = Drawer.Shape.Line;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.shape = Drawer.Shape.Triangle;
        }

        private void eclipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.shape = Drawer.Shape.Eclipse;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.shape = Drawer.Shape.Rectangle;
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            drawer.shape = Drawer.Shape.Rectangle;
        }

        private void Palette_Click(object sender, EventArgs e)
        {
            drawer.shape = Drawer.Shape.Palette;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            drawer.shape = Drawer.Shape.Eraser;
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            drawer.shape = Drawer.Shape.Fill;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            trackBar1.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 25;
            drawer.pen.Width = trackBar1.Value;
            drawer.raser.Width = trackBar1.Value;
            drawer.thickness = trackBar1.Value;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp3;
            bmp3 = new Bitmap(drawer.pictWidth, drawer.pictHeight);
            drawer.g = Graphics.FromImage(bmp3);
            drawer.picture.Image = bmp3;
            drawer.g.Clear(Color.White);
            if (drawer.gp != null)
                drawer.gp.Reset();
            drawer.picture.Refresh();
        }
        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {
            drawer.shape = Drawer.Shape.Fill;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            drawer.shape = Drawer.Shape.Crop;

            /*
            drawer.picture.Width = 100;
            drawer.picture.Height = 200;
            drawer.bmp =  new Bitmap(drawer.picture.Width, drawer.picture.Height);
            drawer.g = Graphics.FromImage(drawer.bmp);
            drawer.picture.Image = drawer.bmp;
        */
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    enum Items
    {
        Free,
        Line,
        Rectangle,
        Triangle,
        Eclipse,
        Palette,
        Eraser,
        Fill,
        Crop
    }
}