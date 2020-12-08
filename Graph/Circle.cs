using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Circle
    {
        private Rectangle rect;
        private Point center;
        private int radius;

        public Circle(Point center, int radius)
        {
            this.center = center;
            this.radius = radius;
            rect = new Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2);
        }

        public Rectangle GetRectangle()
        {
            return rect;
        }

        public Point getCenter()
        {
            return new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
        }

        int getRaius()
        {
            return rect.Width > rect.Height ? rect.Height / 2 : rect.Width / 2;
        }

        public List<Point> getCorners(int count)
        {
            List<Point> points = new List<Point>();
            int R = getRaius();
            Point C = getCenter();
            double T = 2 * Math.PI / count;
            double t = 0;

            for (int i = 1; i <= count; i++)
            {
                Point p = new Point();
                p.X = C.X + (int)Math.Round(R * Math.Cos(t));
                p.Y = C.Y - (int)Math.Round(R * Math.Sin(t));
                t += T;
                points.Add(p);
            }
            return points;
        }
    }
}
