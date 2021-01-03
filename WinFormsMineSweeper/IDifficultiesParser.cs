using WinFormsMineSweeper.Game;

namespace WinFormsMineSweeper
{
    public interface IDifficultiesParser
    {
        GameSettings ParseDifficulty(string name);
    }
}