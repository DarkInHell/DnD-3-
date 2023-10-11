using System;
using System.Reflection.Emit;
using System.Windows.Controls;

namespace DnD
{
    public class Stats : AllVariable
    {
        public void TextString(TextBlock one, TextBlock two, TextBlock three, TextBlock four, string l)
        {
            try
            {
                if (one != null)
                {
                    one.Text = l;
                }
                if (two != null)
                {
                    two.Text = l;
                }
                if (three != null)
                {
                    three.Text = l;
                }
                if (four != null)
                {
                    four.Text = l;
                }
            }
            catch
            {

            }
        }

        public int MasterEnc(TextBox text)
        {
            LvlPoint = Convert.ToInt32(text.Text);
            if (LvlPoint < 6500)
            {
                MasterBonus = 2;
            }
            else if (LvlPoint < 48000)
            {
                MasterBonus = 3;
            }
            else if (LvlPoint < 120000)
            {
                MasterBonus = 4;
            }
            else if (LvlPoint < 225000)
            {
                MasterBonus = 5;
            }
            else if (LvlPoint >= 225000)
            {
                MasterBonus = 6;
            }

            return MasterBonus;
        }

        public int StatsEnc(TextBox Stats)
        {
            StatsNum = Convert.ToInt32(Stats.Text);
            StatsNum = StatsNum / 2 - 5;
            return StatsNum;
        }

        public int SpasChec(TextBlock Spas)
        {
            SpasPointNum = Convert.ToInt32(Spas.Text);
            SpasPointNum += MasterBonus;
            Spas.Text = SpasPointNum.ToString();
            return SpasPointNum;
        }

        public int SpasNoChec(TextBlock Spas)
        {
            SpasPointNum = Convert.ToInt32(Spas.Text);
            SpasPointNum -= MasterBonus;
            Spas.Text = SpasPointNum.ToString();
            return SpasPointNum;
        }
    }
}
