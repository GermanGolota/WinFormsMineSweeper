using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WinFormsMineSweeper.Drawings
{
    public class CoveredCell : Drawing
    {
        public CoveredCell(int width, Point initialPoint) : base(width, initialPoint)
        {

        }
        public override void Draw(Graphics g)
        {
            DrawHelper.DrawCorners(g, this.StartingPoint, this.size);

            SolidBrush brush = new SolidBrush(Color.Gray);

            Size middleSize = new Size((this.size* 4)/5, (this.size*4)/5);
            Point middleStart = new Point(this.StartingPoint.X+this.size/10, this.StartingPoint.Y + this.size / 10);
            Rectangle middle = new Rectangle(middleStart, middleSize);

            g.FillRectangle(brush, middle);

        }   
    }
}
