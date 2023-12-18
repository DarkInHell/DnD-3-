using DnD.ClassesBin;
using DnD.RacesBin;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using static DnD.AllVariable;
using DnD.Player;
using System.Linq;
using System.IO;

namespace DnD
{
    public partial class ChapList : Page
    {
        public ChapList()
        {
            InitializeComponent();
            DataContext = new ChoseRaces();
        }

        private readonly Stats stats = new Stats();
        private readonly UpParam upParam = new UpParam();


        private void LvlBox_LostFocus(object sender, RoutedEventArgs e)
        {
            Level.LevelEnc(LvlBlock, LvlBox);
            MasterBool = true;
            MasterAssign();
        }

        public void MasterAssign()
        {
            if (MasterBool == true)
            {
                MasterNum.Text = "+" + stats.MasterEnc(LvlBox);
                MasterBool = false;
            }
        }

        public void StatsPointEnc()
        {

            string s = Convert.ToString(stats.StatsEnc(StrengthPoint));
            stats.TextString(s, StrengthStats, SSC, ATLSSB);

            string a = Convert.ToString(stats.StatsEnc(AgilityPoint));
            stats.TextString(a, AgilityStats, ASC, AKRSSB, LORSSB, SKRSSB);

            string v = Convert.ToString(stats.StatsEnc(VitalityPoint));
            stats.TextString(v, VitalityStats, VSC);

            string i = Convert.ToString(stats.StatsEnc(IntellectPoint));
            stats.TextString(i, IntellectStats, ISC, ANASSB, ISTSSB, MAGSSB, PRISSB, RELSSB);

            string w = Convert.ToString(stats.StatsEnc(WitPoint));
            stats.TextString(w, WitStats, WSC, VOSSSB, VYZSSB, MEDSSB, PROSSB, UZZSSB);

            string c = Convert.ToString(stats.StatsEnc(CharismaPoint));
            stats.TextString(c, CharismaStats, CSC, VYSSSB, ZAPSSB, OBMSSB, UBESSB);

        }

        private int Score = 0;
        private void PointLostFocus(object sender, RoutedEventArgs e)
        {
            StatsPointEnc();
            Score++;
            if (Score == 6)
            {
                stats.RaceBonus(RaceCombo, ListSkill, StrengthPoint, AgilityPoint, VitalityPoint, IntellectPoint, WitPoint, CharismaPoint);
                StatsPointEnc();
            }
        }

        private void ClickCheck(object sender, RoutedEventArgs e)
        {
            var br = sender as CheckBox;
            br.Content = stats.Check_Uncheck(br);
        }

        private void ClassCombo_LostFocus(object sender, RoutedEventArgs e)
        {
            upParam.Ownership(ClassCombo, ListSkill);
        }

        private void RaceCombo_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Gamer.SaveGamerCombo(ClassCombo, RaceCombo, AlignmentCombo, OriginCombo);
            Gamer.SaveGamerBlock(out string path, PlayerName, CharName, LvlBox);
            Gamer.SaveGamer(path);
        }
    }
}