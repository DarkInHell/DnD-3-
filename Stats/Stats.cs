using DnD.RacesBin;
using System;
using System.Windows;
using System.Windows.Controls;
using static DnD.RacesBin.RacesLog;
using static DnD.AllVariable;
using System.Linq;

namespace DnD
{
    public class Stats 
    {
        bool flag = true;

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

        public void RaceBonus(ComboBox comboBox, TextBox listBox, params TextBox[] textBox)
        {
            string[] StatsNum = new string[textBox.Length];
            textBox.ToList().ForEach(s => StatsNum.Append(s.Text));
            RaceStats[] racesLog = new RaceStats[] { new Human(), new Elf() };
            try
            {
                if (flag)
                {
                    for (int i = 0; i < racesLog.Length; i++)
                    {
                        if (comboBox.Text == racesLog[i].RaceName)
                        {
                            if (!listBox.Text.Contains("\r\n" + "Расовые особенности: "))
                            {
                                listBox.Text += "\r\n" + "Расовые особенности: ";
                                racesLog[i].NameAbility.ToList().ForEach(s => listBox.Text += s + ", ");
                            }
                            for (int k = 0; k < racesLog[i].Point.Length; k++)
                            {
                                RaceStatsEnc(Convert.ToInt32(StatsNum[k]), textBox[k], racesLog[i].Point[k]);
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
            int Num = StatsNum + raceStats + int.Parse(textBox.Text);
            textBox.Text = Num.ToString();
            return textBox.Text;
        }
    }
}
