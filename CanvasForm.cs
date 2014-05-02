using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LineEntityGenerationCG
{
    public partial class CanvasForm : Form
    {
        Bitmap originbmp;
        public CanvasForm(int width, int height)
        {
            InitializeComponent();
            originbmp = new Bitmap(width, height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(originbmp);
            txtpixel.Text = "";
            string[] from = txtFrom.Text.Split(',');
            string[] to = txtTo.Text.Split(',');
            Point fromPoint = new Point(Convert.ToInt32(from[0]),Convert.ToInt32(from[1]));
            Point toPoint = new Point(Convert.ToInt32(to[0]),Convert.ToInt32(to[1]));
            List<Point> listPoint;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (radioDDA.Checked)
                listPoint = AlgorithmDDA(fromPoint, toPoint);
            else
                listPoint = AlgorithmBresenham(fromPoint, toPoint);
            sw.Stop();
            txtTime.Text = "time: " + sw.Elapsed.TotalSeconds;
            foreach (Point p in listPoint)
            {
                txtpixel.Text += p.X + "," + p.Y + "\r\n";
                bmp.SetPixel(p.X,p.Y,Color.Black);
            }
            pictureBox.Image = bmp;
            
        }

        public class RealPoint {
            public double X;
            public double Y;

            public RealPoint(Point p)
            {
                X = (double)p.X;
                Y = (double)p.Y;
            }
            public RealPoint(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        private List<Point> AlgorithmDDA(Point from, Point to)
        {
            List<Point> pointList = new List<Point>();
            List<RealPoint> realList = new List<RealPoint>();
            double k = (to.Y - from.Y)*1.0/(to.X - from.X);
            pointList.Add(from);
            realList.Add(new RealPoint(from));
            if (k >= -1 && k <= 1)
            {
                for (int i = 1; i < to.X - from.X + 1; i++)
                {
                    RealPoint curPoint = realList[i - 1];
                    RealPoint nextPoint = new RealPoint(from.X + i, curPoint.Y + k);
                    Point nextDrawingPoint = new Point(from.X + i, (int)Math.Round(curPoint.Y + k));
                    
                    if (nextPoint.Y >= originbmp.Height)
                        nextPoint.Y = originbmp.Height - 1;
                    if (nextDrawingPoint.Y >= originbmp.Height)
                        nextDrawingPoint.Y = originbmp.Height - 1;

                    realList.Add(nextPoint);
                    pointList.Add(nextDrawingPoint);
                }
            }
            else
            {
                for (int i = 1; i < to.Y - from.Y + 1; i++)
                {
                    RealPoint curPoint = realList[i - 1];
                    RealPoint nextPoint = new RealPoint(curPoint.X + 1.0 / k, from.Y + 1);
                    Point nextDrawingPoint = new Point((int)Math.Round(curPoint.X+1.0/k),from.Y+i);

                    if (nextPoint.X >= originbmp.Width)
                        nextPoint.X = originbmp.Width -1;
                    if (nextDrawingPoint.X >= originbmp.Width)
                        nextDrawingPoint.X = originbmp.Width - 1;
                    realList.Add(nextPoint);
                    pointList.Add(nextDrawingPoint);
                }
            }
            return pointList;
        }

        private List<Point> AlgorithmBresenham(Point from, Point to)
        {
            List<Point> pointList = new List<Point>();
            pointList.Add(from);
            int deltaX = to.X - from.X;
            int deltaY = to.Y - from.Y;
            int p = 2 * deltaY - deltaX;
            double k = deltaY * 1.0 / deltaX;

            if (k <= 1 && k >= -1)
            {
                for (int i = 0; i < Math.Abs(deltaX); i++)
                {
                    Point curpoint = pointList[i];
                    if (p < 0)
                    {
                        if (deltaX > 0)
                            pointList.Add(new Point(curpoint.X + 1, curpoint.Y));
                        else
                            pointList.Add(new Point(curpoint.X - 1, curpoint.Y));
                        p = p + 2 * deltaY;
                    }
                    else
                    {
                        if (deltaX > 0)
                            pointList.Add(new Point(curpoint.X + 1, curpoint.Y + 1));
                        else
                            pointList.Add(new Point(curpoint.X - 1, curpoint.Y + 1));
                        p = p + 2 * deltaY - 2 * deltaX;
                    }
                }
            }
            else
            {
                for (int i = 0; i < Math.Abs(deltaY); i++)
                {
                    Point curpoint = pointList[i];
                    if (p < 0)
                    {
                        pointList.Add(new Point(curpoint.X, curpoint.Y + 1));
                        p = p + 2 * deltaX;
                    }
                    else
                    {
                        pointList.Add(new Point(curpoint.X + 1, curpoint.Y + 1));
                        p = p + 2 * deltaX - 2 * deltaY;
                    }
                
                }
            
            }
           
            return pointList;
        }
    }
}
    