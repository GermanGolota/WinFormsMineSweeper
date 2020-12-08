using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WinFormsMineSweeper.Drawings
{
    public abstract class Drawing
    {
        public int size;
        public Point StartingPoint;
        public Drawing(int width, Point startingPoint)
        {
            this.size = width;
            this.StartingPoint = startingPoint;
        }
        public abstract void Draw(Graphics g);
    }
}
