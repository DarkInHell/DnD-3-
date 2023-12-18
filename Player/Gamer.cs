using DnD.ClassesBin;
using DnD.RacesBin;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using static DnD.AllVariable;
using System;

namespace DnD.Player
{
    public class Gamer
    {
        private static Gamer _gamer;

        private ClassStats _class;
        private RaceStats _race;
        private string _charName;
        private string _playerName;
        private string _alignment;
        private string _origin;
        private int _lvl;

        public ClassStats Class { get { return _class; } set { if (value != null) _class = value; } }
        public RaceStats Race { get { return _race; } set { if (value != null) _race = value; } }
        public string PlayerName { get { return _playerName; } set { if (value != null) _playerName = value; } }
        public string CharName { get { return _charName; } set { if (value != null) _charName = value; } }
        public string Alignment { get { return _alignment; } set { if (value != null) _alignment = value; } }
        public string Origin { get { return _origin; } 
            set 
            { 
                if (value != null) _origin = value;
                else _origin = "-";
            } 
        }
        public int Lvl { get { return _lvl; } set { if (value != null || value != 0) _lvl = value; } }

        public static Gamer CurrentGamer()
        {
            _gamer ??= new Gamer();
            return _gamer;
        }

        public string[] GamerInfo()
        {
            string[] info = new string[] {PlayerName, CharName, Origin, Class.ClassName, Race.RaceName, Alignment, $"{Lvl}" };
            return info;
        }

        public static void SaveGamer(string path)
        {
            FileInfo fileInfo = new(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
                File.AppendAllLines(path, CurrentGamer().GamerInfo());
            }
            else
            {
                File.AppendAllLines(path, CurrentGamer().GamerInfo());
            }
        }

        /// <summary>
        ///        
        /// </summary>
        /// <param name="comboBoxes">1. Класс
        ///        2. Раса
        ///        3. Мировозрение
        ///        4. Происхождение</param>
        public static void SaveGamerCombo(params ComboBox[] comboBoxes)
        {
            Classes.ToList().ForEach(c =>
            {
                if (c.ClassName == $"{comboBoxes[0].SelectedItem}")
                {
                    CurrentGamer().Class = c;
                }
            });
            Races.ToList().ForEach(c =>
            {
                if (c.RaceName == $"{comboBoxes[1].SelectedItem}")
                {
                    CurrentGamer().Race = c;
                }
            });
            CurrentGamer().Alignment = (string)comboBoxes[2].SelectedItem;
            CurrentGamer().Origin = (string)comboBoxes[3].SelectedItem;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">path - Возвращает имя нашего файла</param>
        /// <param name="textBoxs">1.Имя Игрока 2.Имя Персонажа 3.Уровень Персонажа</param>
        public static void SaveGamerBlock(out string path, params TextBox[] textBoxs)
        {
            CurrentGamer().PlayerName = textBoxs[0].Text;
            CurrentGamer().CharName = textBoxs[1].Text;
            CurrentGamer().Lvl = Level.LevelEnc(textBoxs[2]);
            path = textBoxs[1].Text + "(" + textBoxs[0].Text + ")" + ".txt";
        }
    }
}
