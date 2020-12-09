using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsMineSweeper
{
    public class MinesweeperGame
    {
        public event EventHandler PlayerLost;
        public event EventHandler PlayerWon;
        public event EventHandler FlagPlaced;

        private bool GameOver = false;
        private Graphics g;
        private int width;
        private int height;
        private int size;
        private Point Starting;
        private Board board;
        private int mineCount;
        public MinesweeperGame(Form displayForm, int width, int height, int mineCount, int Size, Point StartingPoint)
        {
            
            this.g = displayForm.CreateGraphics();
            this.width = width;
            this.height = height;
            this.mineCount = mineCount;
            this.size = Size;
            this.Starting = StartingPoint;
            this.board = new Board(width, height, mineCount, size, Starting, g);
            this.board.FlagPlaced += Minesweeper_FlagPlaced;
            displayForm.MouseClick += Minesweeper_MouseClick;
        }

        private void Minesweeper_FlagPlaced(object sender, EventArgs e)
        {
            this.FlagPlaced?.Invoke(this, EventArgs.Empty);
        }

        private void Minesweeper_MouseClick(object sender, MouseEventArgs e)
        {
            if (!GameOver)
            {
                int x = e.X; int y = e.Y;
                bool FitsByX = (x <= Starting.X + size && x >= Starting.X);
                bool FitsByY = (y <= Starting.Y + size && y >= Starting.Y);

                if (FitsByX && FitsByY)
                {
                    bool isLeft = e.Button.Equals(MouseButtons.Left);
                    bool isRight = e.Button.Equals(MouseButtons.Right);
                    bool isMiddle = e.Button.Equals(MouseButtons.Middle);
                    int CellSize = size / width;
                    int i = (x - Starting.X) / CellSize;
                    int j = (y - Starting.Y) / CellSize;
                    if (isMiddle)
                    {
                        if (board[i, j].State.Equals(Enums.CellState.Uncovered))
                        {
                            List<Cell> cells = board[i, j].Neighbours;
                            List<Cell> mines = board[i, j].Neighbours.Where(x => x.IsMine == true).ToList();
                            List<Cell> nonMine = board[i, j].Neighbours.Where(x => x.IsMine == false).ToList();
                            bool AllMarked = true;
                            foreach (Cell mine in mines)
                            {
                                if (!mine.State.Equals(Enums.CellState.Flag))
                                {
                                    AllMarked = false;
                                    break;
                                }
                            }
                            if (AllMarked)
                            {
                                foreach (Cell cell in nonMine)
                                {
                                    cell.Uncover(g);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (isLeft)
                        {
                            if (!board[i, j].State.Equals(Enums.CellState.Flag))
                            {
                                if (board[i, j].IsMine)
                                {
                                    GameOver = true;
                                    for (int n = 0; n < width; n++)
                                    {
                                        for (int m = 0; m < height; m++)
                                        {
                                            if (board[n, m].IsMine)
                                            {
                                                board[n, m].State = Enums.CellState.Mine;
                                                board[n, m].Draw(g);
                                            }
                                        }
                                    }
                                    PlayerLost?.Invoke(this, EventArgs.Empty);
                                    return;
                                }
                                else
                                {
                                    board[i, j].Uncover(g);
                                }
                            }
                        }
                        else
                        {
                            if (isRight)
                            {
                                board[i, j].TryPlaceFlag(g);
                            }
                        }
                    }
                }
                int CoveredCount = 0;
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (!board[i, j].IsMine&&board[i,j].State.Equals(Enums.CellState.Covered))
                        {
                            CoveredCount++;
                        }
                    }
                }
                if(CoveredCount==0)
                {
                    PlayerWon?.Invoke(this,EventArgs.Empty);
                    GameOver = true;
                    return;
                }
            }
        }

        public void StartNewGame()
        {
            this.GameOver = false;
            this.board = new Board(width, height, mineCount, size, Starting, g);
            this.board.Draw(g);
            this.board.FlagPlaced += Minesweeper_FlagPlaced;
        }
    }
}
