using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WinFormsMineSweeper.Drawings
{
    public class Flag : Drawing
    {
        public Flag(int width, Point initialPoint) : base(width, initialPoint)
        {

        }
        public override void Draw(Graphics g)
        {
            DrawHelper.DrawCorners(g, this.StartingPoint, this.size);

            SolidBrush brush = new SolidBrush(Color.Gray);

            Size middleSize = new Size((this.size * 4) / 5, (this.size * 4) / 5);
            Point middleStart = new Point(this.StartingPoint.X + this.size / 10, this.StartingPoint.Y + this.size / 10);
            Rectangle middle = new Rectangle(middleStart, middleSize);

            g.FillRectangle(brush, middle);


            int R = this.size / 2;
            Point center = new Point(this.StartingPoint.X+R,this.StartingPoint.Y+R);
            Point top = new Point(center.X,this.StartingPoint.Y+R/3);
            Point bottom = new Point(center.X, this.StartingPoint.Y + this.size- R / 3);
            Point flagEnd = new Point(this.StartingPoint.X+R/3, (top.Y+center.Y)/2);

            Point BaseStart = DrawHelper.GetMiddlePoint(DrawHelper.GetMiddlePoint(center, bottom), bottom);
            Point BaseLeft = new Point(bottom.X-R/3,bottom.Y);
            Point BaseRight = new Point(bottom.X+ R / 3, bottom.Y);

            Pen pen = new Pen(Color.Black,8);
            SolidBrush flag = new SolidBrush(Color.Red);
            SolidBrush Base = new SolidBrush(Color.Black);

            g.DrawLine(pen, bottom, top);

            g.FillPolygon(flag, new Point[] {top, center, flagEnd });
            g.FillPolygon(Base, new Point[] { BaseStart, BaseLeft, BaseRight });
        }
    }
}
