using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsMineSweeper
{
    public class UnavailableDifficultyException: Exception
    {
        public UnavailableDifficultyException(string message):base(message)
        {

        }
    }
}
