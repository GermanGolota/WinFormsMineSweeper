using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WinFormsMineSweeper.Drawings
{
    public class Mine : Drawing
    {
        public Mine(int width, Point initialPoint):base(width, initialPoint)
        {

        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black,4);
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen whitePen = new Pen(Color.White, 4);

            Rectangle rect = new Rectangle(this.StartingPoint, new Size(this.size, this.size));
            g.FillEllipse(brush, rect);
            int R = this.size / 2;

            

            Point center = new Point(this.StartingPoint.X+this.size/2, this.StartingPoint.Y + this.size / 2);
            Point BottomRightSpike = new Point(this.StartingPoint.X+this.size, this.StartingPoint.Y+this.size);
            Point BottomLeftSpike = new Point(this.StartingPoint.X, this.StartingPoint.Y + this.size);
            Point TopLeftSpike = new Point(this.StartingPoint.X, this.StartingPoint.Y);
            Point TopRightSpike = new Point(this.StartingPoint.X + this.size, this.StartingPoint.Y);
            List<Point> spikePoints = new List<Point>();
            spikePoints.Add(BottomRightSpike);
            spikePoints.Add(BottomLeftSpike);
            spikePoints.Add(TopLeftSpike);
            spikePoints.Add(TopRightSpike);

            List<Point> circleSpikePoints = new List<Point>();
            for (int i = 1; i <= 8; i++)
            {
                double span = (2 * i - 1) * Math.PI / 8;

                double xoffset = Math.Cos(span);
                double yoffset = Math.Sin(span);

                xoffset *= R;
                yoffset *= R;

                Point spikePoint = new Point(center.X + (int)xoffset, center.Y + (int)yoffset);
                
                circleSpikePoints.Add(spikePoint);
            }
            for (int i = 0; i < 4; i++)
            {
                Point first = circleSpikePoints[2 * i];
                Point second = circleSpikePoints[2 * i + 1];
                Point[] points = { spikePoints[i] , first, second };
                g.FillPolygon(brush, points);

                double span = (2*i+1)* Math.PI / 4;

                double xoffset = Math.Cos(span);
                double yoffset = Math.Sin(span);

                xoffset *= R;
                yoffset *= R;

                Point middle = new Point(center.X + (int)xoffset, center.Y + (int)yoffset);

                Point temp = DrawHelper.GetMiddlePoint(middle, center);

                Point third = DrawHelper.GetMiddlePoint(temp, middle);

                g.DrawCurve(whitePen, new Point[] { first,third, second  });
            }
            int initialCircleOffset = R * 2 / 3;
            Point initialCircle = new Point(this.StartingPoint.X+ initialCircleOffset, this.StartingPoint.Y+ initialCircleOffset);

            

            g.DrawEllipse(whitePen, new Rectangle(initialCircle, new Size(initialCircleOffset, initialCircleOffset)));
        }
    }
}
