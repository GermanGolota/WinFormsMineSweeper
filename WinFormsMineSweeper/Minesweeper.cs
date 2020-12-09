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
        int mineCount =15;
        MinesweeperGame game;
        public Minesweeper()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            g = this.CreateGraphics();
            game = new MinesweeperGame(this, width, height,mineCount, size, Starting);
            game.PlayerLost += Game_PlayerLost;
            game.PlayerWon += Game_PlayerWon;
        }

        private void Game_PlayerWon(object sender, EventArgs e)
        {
            MessageBox.Show("You have won, congratulations!!!");
        }

        private void Game_PlayerLost(object sender, EventArgs e)
        {
            MessageBox.Show("You have lost, congratulations!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.StartNewGame();
        }
    }
}
