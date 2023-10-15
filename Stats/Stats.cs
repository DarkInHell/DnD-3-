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
            var _human = new Human();
            try
            {
                if (comboBox.Text == _human.NameRace)
                {
                    listBox.Text += "\r\n" + "Расовые особенности: ";
                    for (int i = 0; i < _human.NameAbility.Length; i++)
                    {
                        listBox.Text += _human.NameAbility[i] + " ";
                    }
                    StatsNum1 += _human.PointStr;
                    StatsNum2 += _human.PointDex;
                    StatsNum3 += _human.PointVit;
                    StatsNum5 += _human.PointWit;
                    StatsNum4 += _human.PointInt;
                    StatsNum6 += _human.PointCha;
                    one.Text = StatsNum1.ToString();
                    two.Text = StatsNum2.ToString();
                    three.Text = StatsNum3.ToString();
                    four.Text = StatsNum4.ToString();
                    five.Text = StatsNum5.ToString();
                    six.Text = StatsNum6.ToString();
                }
            }
            catch { }
        }
    }
}
