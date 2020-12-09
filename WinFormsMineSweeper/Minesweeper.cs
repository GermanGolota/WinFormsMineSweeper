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
        private Graphics g;
        private MinesweeperGame game;
        private int FlagCount;
        private int mineCount = 15;
        public Minesweeper()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            g = this.CreateGraphics();

            FlagCount = mineCount;

            game = new MinesweeperGame(this, 10, 10,mineCount, 800, new Point(120, 150));
            game.PlayerLost += Game_PlayerLost;
            game.PlayerWon += Game_PlayerWon;
            game.FlagPlaced += Game_FlagPlaced;
            game.FlagDeleted += Game_FlagDeleted;
        }

        private void Game_FlagDeleted(object sender, EventArgs e)
        {
            FlagCount++;
            UpdateFlagCount();
        }

        private void UpdateFlagCount()
        {
            this.MinesLabel.Text = this.FlagCount.ToString();
        }

        private void Game_FlagPlaced(object sender, EventArgs e)
        {
            FlagCount--;
            UpdateFlagCount();
        }

        private void Game_PlayerWon(object sender, EventArgs e)
        {
            MessageBox.Show("You have won, congratulations!!!");
        }

        private void Game_PlayerLost(object sender, EventArgs e)
        {
            MessageBox.Show("You have lost, congratulations!!!");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            game.StartNewGame();
            Flag flag = new Flag(100, new Point(50, 20));
            flag.Draw(g);
            FlagCount = mineCount;
            UpdateFlagCount();
        }
    }
}
