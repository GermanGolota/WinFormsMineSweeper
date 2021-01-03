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
using WinFormsMineSweeper.Game;

namespace WinFormsMineSweeper
{
    public partial class Minesweeper : Form
    {
        private Graphics g;
        private MinesweeperGame game;
        private int FlagCount;
        public GameSettings Settings { get; }
        public OptionsSelectionForm OptionsForm { get; }

        public Minesweeper(GameSettings settings, OptionsSelectionForm optionsForm)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            g = this.CreateGraphics();


            Settings = settings;
            OptionsForm = optionsForm;

            FlagCount = settings.MineCount;
            Point startingPoint = new Point(120, 150);
            int Size = 800;

            game = new MinesweeperGame(this, settings, Size, startingPoint);
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
            FlagCount = Settings.MineCount;
            UpdateFlagCount();
        }

        private void DifficultyButton_Click(object sender, EventArgs e)
        {
            OptionsForm.Show();
            this.Close();
        }
    }
}
