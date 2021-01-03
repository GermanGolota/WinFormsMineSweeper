using System;
using System.Collections.Generic;
using System.Text;
using WinFormsMineSweeper.Game;

namespace WinFormsMineSweeper
{
    public class MockDifficultyParser : IDifficultiesParser
    {
        public GameSettings ParseDifficulty(string name)
        {
            //Move to json document, that would later be parsed
            switch (name)
            {
                case "Easy":
                    return new GameSettings { Height = 8, Width = 8, MineCount = 10 };
                case "Medium":
                    return new GameSettings { Height = 12, Width = 12, MineCount = 30 };
                case "Hard":
                    return new GameSettings { Height = 16, Width = 16, MineCount = 50 };
                default:
                    throw new UnavailableDifficultyException("Unevailable difficulty");
            }
        }
    }
}
