using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using WinFormsMineSweeper.Drawings;
using static WinFormsMineSweeper.Enums;

namespace WinFormsMineSweeper
{
    public class Cell:Drawing
    {

        public event EventHandler FlagSuccesfullyPlaced;
        public event EventHandler FlagDeleted;
        public int X { get; set; }
        public int Y { get; set; }
        public CellState State { get; set; }
        public bool IsMine { get; set; }
        public int Value { get; set; }
        public List<Cell> Neighbours { get; set; }
        public Cell(int x, int y, Point Location, int size):base(size, Location)
        {
            this.X = x;
            this.Y = y;
            this.IsMine = false;
            this.State = CellState.Covered;
        }
        public void Uncover(Graphics g)
        {
            if (this.State.Equals(CellState.Covered)&&!this.IsMine)
            {
                this.State = CellState.Uncovered;
                if(this.Value==0)
                {
                    foreach(Cell neighbour in this.Neighbours)
                    {
                        neighbour.Uncover(g);
                    }
                }
                this.Draw(g);
            }
        }
        public void SetNeighbours(Board board)
        {
            List<Cell> output = new List<Cell>();
            for (int n = -1; n < 2; n++)
            {
                for (int m = -1; m < 2; m++)
                {
                    if (n != 0 || m != 0)
                    {
                        int xpos = this.X + n;
                        int ypos = this.Y + m;
                        if (xpos != -1 && ypos != -1 && xpos < board.width && ypos < board.height)
                        {
                            output.Add(board[xpos,ypos]);
                        }
                    }
                }
            }
            this.Neighbours = output;
            int mines = 0;
            foreach (Cell neighbour in this.Neighbours)
            {
                if(neighbour.IsMine)
                {
                    mines++;
                }
            }
            this.Value = mines;
        }
        public void TryPlaceFlag(Graphics g)
        {
            switch (this.State)
            {
                case CellState.Covered:
                    FlagSuccesfullyPlaced?.Invoke(this,EventArgs.Empty);
                    this.State = CellState.Flag;
                    this.Draw(g);
                    break;
                case CellState.Flag:
                    this.State = CellState.Covered;
                    FlagDeleted?.Invoke(this,EventArgs.Empty);
                    this.Draw(g);
                    break;
                default:
                    break;
            }
        }
        public override void Draw(Graphics g)
        {
            switch (this.State)
            {
                case CellState.Covered:
                    CoveredCell coveredCell = new CoveredCell(this.size, this.StartingPoint);
                    coveredCell.Draw(g);
                    break;
                case CellState.Uncovered:
                    UncoveredCell uncoveredCell = new UncoveredCell(this.size, this.StartingPoint, this.Value);
                    uncoveredCell.Draw(g);
                    break;
                case CellState.Flag:
                    Flag flag = new Flag(this.size, this.StartingPoint);
                    flag.Draw(g);
                    break;
                case CellState.Mine:
                    Mine mine = new Mine(this.size, this.StartingPoint);
                    mine.Draw(g);
                    break;
                default:
                    break;
            }
        }
    }
}
