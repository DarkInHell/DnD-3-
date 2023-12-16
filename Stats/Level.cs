using System;
using System.Windows.Controls;

namespace DnD
{
    public static class Level
    {
        public static string LevelEnc(TextBlock block, TextBox text)
        {
            AllVariable allVariable = new()
            {
                LvlPoint = Convert.ToInt32(text.Text)
            };

            for (int i = 0; i < allVariable.Lvl.Length; i++)
            {
                if (allVariable.LvlPoint >= allVariable.Lvl[i])
                {
                    allVariable.LvlView = i + 1;
                    block.Text = $"{allVariable.LvlView}";
                }
            }

            return block.Text;
        }
    }
}
