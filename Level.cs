using System;
using System.Windows.Controls;

namespace DnD
{
    public class Level : AllVariable
    {
        public string LevelEnc(TextBlock block, TextBox text)
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
    }
}
