using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WinFormsMineSweeper.Drawings
{
    public class UncoveredCell : Drawing
    {
        public int Value { get; }
        public UncoveredCell(int width, Point initialPoint, int value) : base(width, initialPoint)
        {
            if (value >= 0 && value <= 8)
            {
                Value = value;
            }
        }
        public override void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.LightSlateGray);
            Rectangle rect = new Rectangle(this.StartingPoint, new Size(this.size, this.size));
            g.FillRectangle(brush, rect);

            FontFamily fontFamily = new FontFamily("Arial");
            Font drawFont = new Font( fontFamily, (this.size*8)/10, FontStyle.Regular, GraphicsUnit.Pixel);

            Color textColor = this.GetCellColor(this.Value);

            SolidBrush textBrush = new SolidBrush(textColor);

            if (this.Value!=0)
            {
                g.DrawString(this.Value.ToString(), drawFont, textBrush,
                    new Point(this.StartingPoint.X+size/10, this.StartingPoint.Y + size / 10));
            }
            DrawHelper.DrawCorners(g, this.StartingPoint, this.size);
        }

        private Color GetCellColor(int value)
        {
            Color textColor = Color.Black;
            switch (value)
            {
                case 1:
                    textColor = Color.Blue;
                    break;
                case 2:
                    textColor = Color.Green;
                    break;
                case 3:
                    textColor = Color.Red;
                    break;
                case 4:
                    textColor = Color.Purple;
                    break;
                case 5:
                    textColor = Color.DarkRed;
                    break;
                case 6:
                    textColor = Color.Cyan;
                    break;
                case 8:
                    textColor = Color.DarkGray;
                    break;
            }
            return textColor;
        }
    }
}
