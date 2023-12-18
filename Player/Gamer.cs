using DnD.ClassesBin;
using DnD.RacesBin;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using static DnD.AllVariable;

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
        private int[] _stats;

        public ClassStats Class { get { return _class; } set { if (value != null) _class = value; } }
        public RaceStats Race { get { return _race; } set { if (value != null) _race = value; } }
        public string PlayerName { get { return _playerName; } set { if (value != null) _playerName = value; } }
        public string CharName { get { return _charName; } set { if (value != null) _charName = value; } }
        public string Alignment { get { return _alignment; } set { if (value != null) _alignment = value; } }
        public string Origin { get { return _origin; } set { if (value != null) _origin = value; else _origin = "-"; } }
        public int Lvl { get { return _lvl; } set { if (value is not 0) _lvl = value; } }
        public int[] StatsPoint { get { return _stats; } set { if (value.Length == 6) _stats = value; else _stats.Append(0); } }

        private static Gamer CurrentGamer()
        {
            _gamer ??= new Gamer();
            return _gamer;
        }

        private string[] GamerInfo()
        {
            string[] info =
            [
            $"Имя игрока: {PlayerName}",
            $"Имя персонажа: {CharName}",
            $"Происхождение: {Origin}",
            $"Класс: {Class.ClassName}",
            $"Раса: {Race.RaceName}",
            $"Мировоззрение: {Alignment}",
            $"Уровень: {Lvl}",
            $"Сила: {CurrentGamer().StatsPoint[0]}",
            $"Ловкость: {CurrentGamer().StatsPoint[1]}",
            $"Телосложение: {CurrentGamer().StatsPoint[2]}",
            $"Интеллект: {CurrentGamer().StatsPoint[3]}",
            $"Мудрость: {CurrentGamer().StatsPoint[4]}",
            $"Харизма: {CurrentGamer().StatsPoint[5]}"
            ];
            return info;
        }

        public static void SaveGamer()
        {
            FileInfo fileInfo = new(_path);
            if (fileInfo.Exists)
            {
                File.Delete(_path);
                File.AppendAllLines(_path, CurrentGamer().GamerInfo());
            }
            else
            {
                File.AppendAllLines(_path, CurrentGamer().GamerInfo());
            }
        }

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
        private static string _path;

        public static void SaveGamerBlock(params TextBox[] textBoxs)
        {
            CurrentGamer().PlayerName = textBoxs[0].Text;
            CurrentGamer().CharName = textBoxs[1].Text;
            CurrentGamer().Lvl = Level.LevelEnc(textBoxs[2]);
            _path = textBoxs[1].Text + "(" + textBoxs[0].Text + ")" + ".txt";
        }

        public static void SaveGamerStats(int[] stats)
        {
            CurrentGamer().StatsPoint = stats;
        }
    }
}
