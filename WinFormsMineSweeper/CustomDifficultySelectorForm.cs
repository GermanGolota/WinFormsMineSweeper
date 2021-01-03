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
    public partial class CustomDifficultySelectorForm : Form
    {
        public event EventHandler<GameSettings> SettingsSelectedRaised;
        public CustomDifficultySelectorForm()
        {
            InitializeComponent();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                var settings = GetGameSettings();
                SettingsSelectedRaised?.Invoke(this, settings);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please reconsider your input");
            }
        }

        private GameSettings GetGameSettings()
        {
            int width = GetNumberFromField(WidthField);
            int height = GetNumberFromField(HeightField);
            int mines = GetNumberFromField(MinesField);
            GameSettings output = new GameSettings
            {
                Height = height,
                Width = width,
                MineCount = mines
            };
            return output;
        }
        public int GetNumberFromField (TextBox field)
        {
            return int.Parse(field.Text);
        }
    }
}
