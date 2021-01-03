using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WinFormsMineSweeper
{
    public static class DrawHelper
    {
        public static Point GetMiddlePoint(Point A,Point B)
        {
            return new Point((A.X + B.X) / 2, (A.Y + B.Y) / 2);
        }
        public static void DrawCorners(Graphics g, Point Startingpoint, int width)
        {
            Point topLeft = Startingpoint;
            Point bottomLeft = new Point(topLeft.X, topLeft.Y + width);
            Point bottomRight = new Point(topLeft.X + width, topLeft.Y + width);
            Point topRight = new Point(topLeft.X + width, topLeft.Y);

            Pen pen = new Pen(Color.Black, 2);

            g.DrawPolygon(pen, new Point[] { topLeft, bottomLeft, bottomRight, topRight });

        }
    }
}
