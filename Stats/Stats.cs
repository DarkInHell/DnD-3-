using DnD.RacesBin;
using System;
using System.Windows;
using System.Windows.Controls;
using static DnD.RacesBin.RacesLog;

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

        public void TextString(string l, TextBlock checkBox, params CheckBox[] checkBoxes)
        {
            try
            {
                for (int i = 0; i < checkBoxes.Length; i++)
                {
                    if (checkBoxes[i] != null)
                    {
                        checkBoxes[i].Content = l;
                    }
                }
                checkBox.Text = l;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
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

        public int SpasChec(CheckBox Spas)
        {
            SpasPointNum = Convert.ToInt32(Spas.Content);
            SpasPointNum += MasterBonus;
            Spas.Content = SpasPointNum.ToString();
            return SpasPointNum;
        }

        public int SpasNoChec(CheckBox Spas)
        {
            SpasPointNum = Convert.ToInt32(Spas.Content);
            SpasPointNum -= MasterBonus;
            Spas.Content = SpasPointNum.ToString();
            return SpasPointNum;
        }

        public object Check_Uncheck(CheckBox checkBox)
        {
            if (checkBox.IsChecked == true)
            {
                SpasChec(checkBox);
            }
            else
            {
                SpasNoChec(checkBox);
            }
            return checkBox.Content;
        }

        bool flag = true;
        public void RaceBonus(ComboBox comboBox, TextBox listBox, TextBox one, TextBox two, TextBox three, TextBox four, TextBox five, TextBox six)
        {
            TextBox[] textBoxes = new TextBox[] { one, two, three, four, five, six };
            string[] StatsNum = new string[] { one.Text, two.Text, three.Text, four.Text, five.Text, six.Text };
            RaceStats[] racesLog = new RaceStats[] { new Human(), new Elf() };
            try
            {
                if (flag)
                {
                    for (int i = 0; i < racesLog.Length - 1; i++)
                    {
                        if (comboBox.Text == racesLog[i].NameRace)
                        {
                            if (!listBox.Text.Contains("\r\n" + "Расовые особенности: "))
                            {
                                listBox.Text += "\r\n" + "Расовые особенности: ";
                                for (int j = 0; j < racesLog[i].NameAbility.Length; j++)
                                {
                                    listBox.Text += racesLog[i].NameAbility[j] + " ";
                                }
                            }
                            for (int k = 0; k < racesLog[i].Point.Length; k++)
                            {
                                RaceStatsEnc(Convert.ToInt32(StatsNum[k]), textBoxes[k], racesLog[i].Point[k]);
                            }
                        }
                    }
                    flag = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public string RaceStatsEnc(int StatsNum, TextBox textBox, int raceStats)
        {
            var Num = StatsNum + raceStats;
            textBox.Text = Num.ToString();
            return textBox.Text;
        }
    }
}
