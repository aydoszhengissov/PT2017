using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Paint
{
    class Drawer
    {
        public enum Shape { Pencil, Eclipse, Rectangle, Line, Fill, Triangle, Palette, Eraser, Crop };

        public Graphics g;
        public GraphicsPath gp;

        public Point prev;
        public Bitmap bmp;
        public Pen pen;
        public Pen raser;
        public SolidBrush brush;
        public bool ok = false;
        public PictureBox picture;
        public Shape shape;
        public Queue<Point> q = new Queue<Point>();
        public bool[,] used;
        public Color color = Color.Black;
        public int thickness = 1;
        public Rectangle cropRect;
        public int pictWidth;
        public int pictHeight;

        public Drawer(PictureBox p)
        {
            picture = p;
            bmp = new Bitmap(picture.Width, picture.Height);
            pictWidth = picture.Width;
            pictHeight = picture.Height;
            pen = new Pen(color, thickness);
            brush = new SolidBrush(Color.Blue);
            raser = new Pen(Color.White, 5);

            used = new bool[picture.Width + 1, picture.Height + 1];
            g = Graphics.FromImage(bmp);
            picture.Image = bmp;

            shape = Shape.Pencil;
            picture.Paint += Picture_Paint;
        }


        public void Picture_Paint(object sender, PaintEventArgs e)
        {
            if (gp != null)
            {
                if (shape == Drawer.Shape.Crop)
                {
                    Pen cropPen = new Pen(Color.Black, 1);
                    cropPen.DashStyle = DashStyle.DashDotDot;
                    e.Graphics.DrawPath(cropPen, gp);
                }
                else
                {
                    e.Graphics.DrawPath(pen, gp);
                }
            }
        }

        public void SaveLastPath()
        {
            if (gp != null)
            {
                if (shape == Drawer.Shape.Crop)
                {
                    Pen cropPen = new Pen(Color.Black, 1);
                    g.DrawPath(cropPen, gp);
                    crop(cropRect);
                    picture.Refresh();

                }
                else
                {
                    g.DrawPath(pen, gp);
                    gp = null;
                }
            }
        }

        public void Draw(Point cur)
        {
            switch (shape)
            {
                case Shape.Pencil:
                    g.DrawLine(pen, prev, cur);
                    prev = cur;
                    break;
                case Shape.Rectangle:
                    gp = new GraphicsPath();
                    gp.AddRectangle(new Rectangle(Math.Min(prev.X, cur.X), Math.Min(prev.Y, cur.Y), Math.Abs(cur.X - prev.X), Math.Abs(cur.Y - prev.Y)));
                    break;
                case Shape.Eclipse:
                    gp = new GraphicsPath();
                    gp.AddEllipse(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                    break;
                case Shape.Line:
                    gp = new GraphicsPath();
                    gp.AddLine(prev, cur);
                    break;

                case Shape.Eraser:
                    g.DrawLine(raser, prev, cur);
                    prev = cur;

                    break;
                case Shape.Triangle:
                    gp = new GraphicsPath();
                    Point newpoint1 = new Point((prev.X + cur.X) / 2, prev.Y);
                    Point newpoint2 = new Point(prev.X, cur.Y);
                    Point newpoint3 = new Point(cur.X, cur.Y);
                    gp.AddLine(newpoint1, newpoint2);
                    gp.AddLine(newpoint2, newpoint3);
                    gp.AddLine(newpoint3, newpoint1);
                    break;
                case Shape.Palette:
                    pen = new Pen(bmp.GetPixel(cur.X, cur.Y), thickness);
                    break;
                case Shape.Crop:
                    gp = new GraphicsPath();
                    cropRect = new Rectangle(Math.Min(prev.X, cur.X), Math.Min(prev.Y, cur.Y), Math.Abs(cur.X - prev.X), Math.Abs(cur.Y - prev.Y));
                    gp.AddRectangle(cropRect);
                    break;
                default: break;
            }
            picture.Refresh();
        }


        public void crop(Rectangle rect)
        {
            Bitmap bmp2;
            bmp2 = new Bitmap(rect.Width, rect.Height);
            g = Graphics.FromImage(bmp2);
            g.DrawImage(bmp, new Rectangle(-1, -1, rect.Width, rect.Height),
                                rect,
                                GraphicsUnit.Pixel);
            picture.Image = bmp2;
            picture.Refresh();
        }

        public void fill(Point cur)
        {
            Color clicked_color = bmp.GetPixel(cur.X, cur.Y);
            check(cur.X, cur.Y, clicked_color);
            color = pen.Color;

            for (int i = 0; i < picture.Width; ++i)
                for (int j = 0; j < picture.Height; ++j)
                    used[i, j] = false;

            while (q.Count > 0)
            {
                Point p = q.Dequeue();
                check(p.X + 1, p.Y, clicked_color);
                check(p.X - 1, p.Y, clicked_color);
                check(p.X, p.Y + 1, clicked_color);
                check(p.X, p.Y - 1, clicked_color);
            }
            picture.Refresh();
        }

        public void check(int x, int y, Color col)
        {
            if (x > 0 && y > 0 && x < picture.Width && y < picture.Height &&
                    used[x, y] == false && bmp.GetPixel(x, y) == col)
            {
                used[x, y] = true;
                q.Enqueue(new Point(x, y));
                bmp.SetPixel(x, y, color);
            }
        }

        public void SaveImage(string filename)
        {
            bmp.Save(filename);
        }

        public void OpenImage(string filename)
        {
            bmp = filename == "" ? new Bitmap(picture.Width, picture.Height)
                : new Bitmap(filename);
            g = Graphics.FromImage(bmp);
            picture.Image = bmp;
        }
    }
}