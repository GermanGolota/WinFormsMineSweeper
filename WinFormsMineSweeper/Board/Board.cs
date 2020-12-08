using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using WinFormsMineSweeper.Drawings;

namespace WinFormsMineSweeper
{
    public class Board:Drawing
    {
        public Graphics g;
        public int width { get; set; }
        public int height { get; set; }
        public Cell[,] cells { get; set; }
        public Cell this[int index, int index2]
        {
            get
            {
                return cells[index, index2];
            }
            private set
            {
                this.cells[index, index2] = value;
            }
        }
        public Board(int width, int height, int MineCount, int Size,Point location, Graphics g):base(Size, location)
        {
            this.width = width;
            this.height = height;
            int CellSize = this.size / this.width;
            this.cells = new Cell[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Point CellLocation = new Point(this.StartingPoint.X+i*CellSize, this.StartingPoint.Y+j*CellSize);
                    this[i, j] = new Cell(i,j,CellLocation,CellSize);
                }
            }
            for (int i = 0; i < MineCount; i++)
            {
                bool beenSet = SetMine();
                while(!beenSet)
                {
                    beenSet = SetMine();
                }
            }
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    this[i, j].SetNeighbours(this);
                }
            }
        }
        private bool SetMine()
        {
            Random rng = new Random();
            int x = rng.Next(0, width - 1);
            int y = rng.Next(0, height - 1);
            if(!this[x,y].IsMine)
            {
                this[x, y].IsMine = true;
                return true;
            }
            return false;
        }

        public override void Draw(Graphics g)
        {
            for (int i = 0; i < this.width; i++)
            {
                for (int j = 0; j < this.height; j++)
                {
                    this[i, j].Draw(g);
                }
            }
        }
        
    }
}
