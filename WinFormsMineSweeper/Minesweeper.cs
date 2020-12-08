using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMineSweeper.Drawings;

namespace WinFormsMineSweeper
{
    public partial class Minesweeper : Form
    {
        Graphics g;
        int width = 10;
        int height = 10;
        int size = 800;
        Point Starting = new Point(20, 100);
        Board board;
        int mineCount =15;
        public Minesweeper()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            g = this.CreateGraphics();
            board = new Board(width, height, mineCount, size, Starting, g);
            this.MouseClick += Minesweeper_MouseClick;
        }

        private void Minesweeper_MouseClick(object sender, MouseEventArgs e)
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
                    List<Cell> cells = board[i, j].Neighbours;
                    List<Cell> mines = board[i, j].Neighbours.Where(x => x.IsMine == true).ToList();
                    List<Cell> nonMine = board[i, j].Neighbours.Where(x => x.IsMine == false).ToList();
                    bool AllMarked = true;
                    foreach (Cell mine in mines)
                    {
                        if(!mine.State.Equals(Enums.CellState.Flag))
                        {
                            AllMarked = false;
                            break;
                        }
                    }
                    if(AllMarked)
                    {
                        foreach (Cell cell in nonMine)
                        {
                            cell.Uncover(g);
                        }
                    }
                }
                else
                {
                    if (isLeft)
                    {
                        if (board[i, j].IsMine)
                        {
                            MessageBox.Show("You have lost");
                        }
                        else
                        {
                            board[i, j].Uncover(g);
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
        }


        private void button1_Click(object sender, EventArgs e)
        {
            board.Draw(g);
        }
    }
}
