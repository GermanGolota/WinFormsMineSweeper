using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsMineSweeper.Game;

namespace WinFormsMineSweeper
{
    public partial class OptionsSelectionForm : Form
    {
        private readonly IDifficultiesParser _parser;
        private bool difficultySelected = false;
        public GameSettings Settings { get; set; }
                
        public OptionsSelectionForm(IDifficultiesParser parser)
        {
            this._parser = parser;
            InitializeComponent();
            foreach (Button button in PredeterminedDificultiesContainer.Controls)
            {
                button.Click += PredefinedButtonClicked;
            }
        }

        public void UpdateVisualClues()
        {
            MineLabel.Text = "Mines: " + Settings.MineCount.ToString() ?? "N/A";
            string size = Settings.Width.ToString()+" "+ Settings.Height.ToString();
            SizeLabel.Text = "Size: " + size ?? "N/A";
        }
        public void PredefinedButtonClicked(object sender, EventArgs e)
        {
            Control control = (sender as Control);
            try
            {
                Settings = _parser.ParseDifficulty(control.Tag.ToString());
                difficultySelected = true;
                UpdateVisualClues();
            }
            catch(UnavailableDifficultyException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if(difficultySelected)
            {
                Minesweeper minesweeper = new Minesweeper(Settings, this);
                minesweeper.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please consider selecting a difficulty");
            }
        }

        private void CustomButton_Click(object sender, EventArgs e)
        {
            CustomDifficultySelectorForm form = new CustomDifficultySelectorForm();
            form.SettingsSelectedRaised += CustomSettingsForm_SettingsSelectedRaised;
            form.ShowDialog();
        }

        private void CustomSettingsForm_SettingsSelectedRaised(object sender, GameSettings settings)
        {
            Settings = settings;
            difficultySelected = true;
            UpdateVisualClues();
        }
    }
}
