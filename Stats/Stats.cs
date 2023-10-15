using DnD.RacesBin;
using System;
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
            catch { }
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

        public string Check_Uncheck(TextBlock textBlock, CheckBox checkBox)
        {
            if (checkBox.IsChecked == true)
            {
                SpasChec(textBlock);
            }
            else
            {
                SpasNoChec(textBlock);
            }
            return textBlock.Text;
        }
        public void RaceBonus (ComboBox comboBox, TextBox listBox, TextBox one, TextBox two, TextBox three, TextBox four, TextBox five, TextBox six)
        {
            var StatsNum1 = Convert.ToInt32(one.Text);
            var StatsNum2 = Convert.ToInt32(two.Text);
            var StatsNum3 = Convert.ToInt32(three.Text);
            var StatsNum4 = Convert.ToInt32(four.Text);
            var StatsNum5 = Convert.ToInt32(five.Text);
            var StatsNum6 = Convert.ToInt32(six.Text);
            RacesLog racesLog = new();
            var _human = racesLog.Human();
            try
            {
                if (comboBox.Text == _human.NameRace)
                {
                    listBox.Text += "\r\n" + "Расовые особенности: ";
                    for (int i = 0; i < _human.NameAbility.Length; i++)
                    {
                        listBox.Text += _human.NameAbility[i] + " ";
                    }
                    RaceStatsEnc(StatsNum1, one, _human.PointStr);
                    RaceStatsEnc(StatsNum2, two, _human.PointDex);
                    RaceStatsEnc(StatsNum3, three, _human.PointVit);
                    RaceStatsEnc(StatsNum4, four, _human.PointInt);
                    RaceStatsEnc(StatsNum5, five, _human.PointWit);
                    RaceStatsEnc(StatsNum6, six, _human.PointCha);
                }
            }
            catch { }
        }

        public string RaceStatsEnc (int StatsNum, TextBox textBox, int raceStats)
        {
            var Num = StatsNum + raceStats;
            textBox.Text = Num.ToString();
            return textBox.Text;
        }
    }
}
