using DnD.ClassesBin;
using DnD.RacesBin;
using static DnD.RacesBin.RacesLog;

namespace DnD
{
    public static class AllVariable
    {
        public static bool Stats = false;
        public static bool DopStats = false;
        public static bool MasterBool = false;

        public static int StatsNum;
        public static int MasterBonus;
        public static int SpasPointNum;
        public static int LvlPoint;
        public static int LvlView;

        public static string[] Alignments = new string[] { "Зак. добрый",
                                                           "Зак. нейтр.",
                                                           "Зак. злой",
                                                           "Нейтр. добрый",
                                                           "Нейтр. нейтр.",
                                                           "Нейтр. злой",
                                                           "Хаот. добрый",
                                                           "Хаот. нейтр.",
                                                           "Хаот. злой"};

        public static ClassStats[] Classes = new ClassStats[] { new Warrior(), new Rogue() };
        public static RaceStats[] Races = new RaceStats[] { new Human(), new Elf() };



        public static int[] Lvl = new int[] 
            {0, 300, 900, 2700, 
            6500, 14000, 23000, 34000, 
            48000, 64000, 85000, 100000, 
            120000, 140000, 165000, 195000, 
            225000, 265000, 305000, 355000};
    }
}
