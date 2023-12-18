using System;
using System.Windows.Controls;
using static DnD.AllVariable;

namespace DnD
{
    public static class Level
    {
        public static string LevelEnc(TextBlock block, TextBox text)
        {
            LvlPoint = Convert.ToInt32(text.Text);

            for (int i = 0; i < Lvl.Length; i++)
            {
                if (LvlPoint >= Lvl[i])
                {
                    LvlView = i + 1;
                    block.Text = $"{LvlView}";
                }
            }

            return block.Text;
        }
        public static int LevelEnc(TextBox text)
        {
            LvlPoint = Convert.ToInt32(text.Text);

            for (int i = 0; i < Lvl.Length; i++)
            {
                if (LvlPoint >= Lvl[i])
                {
                    LvlView = i + 1;
                }
            }

            return LvlView;
        }
    }
}
