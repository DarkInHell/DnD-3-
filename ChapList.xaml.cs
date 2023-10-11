using System;
using System.Windows;
using System.Windows.Controls;

namespace DnD
{
    /// <summary>
    /// Логика взаимодействия для ChapList.xaml
    /// </summary>
    public partial class ChapList : Page
    {
        public Stats stats = new Stats();
        public AllVariable allBool = new AllVariable();

        public ChapList()
        {
            InitializeComponent();
            DataContext = new ChoseRaces();
        }

        private void LvlBox_LostFocus(object sender, RoutedEventArgs e)
        {
            Level level = new Level();
            level.LevelEnc(LvlBlock, LvlBox);
            allBool.MasterBool = true;
            MasterAssign();
        }

        public void MasterAssign()
        {
            if (allBool.MasterBool == true)
            {
                MasterNum.Text = "+" + stats.MasterEnc(LvlBox);
                allBool.MasterBool = false;
            }
        }

        public void StatsPointEnc()
        {
            if (allBool.Stats == true)
            {
                string s = Convert.ToString(stats.StatsEnc(StrengthPoint));
                stats.TextString(StrengthStats, StrengthSpas, ATLSS, null, s);

                string a = Convert.ToString(stats.StatsEnc(AgilityPoint));
                stats.TextString(AgilityStats, AgilitySpas, AKRSS, LOVRSS, a);
                stats.TextString(SKRSS, null, null, null, a);

                string v = Convert.ToString(stats.StatsEnc(VitalityPoint));
                stats.TextString(VitalityStats, VitalitySpas, null, null, v);

                string i = Convert.ToString(stats.StatsEnc(IntellectPoint));
                stats.TextString(IntellectStats, IntellectSpas, ANASS, ISTSS, i);
                stats.TextString(MAGSS, PRISS, RELSS, null, i);

                string w = Convert.ToString(stats.StatsEnc(WitPoint));
                stats.TextString(WitStats, WitSpas, VOSSS, VYZSS, w);
                stats.TextString(MEDSS, PROSS, UZZSS, null, w);

                string c = Convert.ToString(stats.StatsEnc(CharismaPoint));
                stats.TextString(CharismaStats, CharismaSpas, VYSSS, ZAPSS, c);
                stats.TextString(OBMSS, UBESS, null, null, c);

                allBool.Stats = false;
            }
            allBool.DopStats = true;
        }

        public void PointLostFocus()
        {
            allBool.Stats = true;
            StatsPointEnc();
        }

        private void StrengthPoint_LostFocus(object sender, RoutedEventArgs e)
        {
            PointLostFocus();
        }

        private void AgilityPoint_LostFocus(object sender, RoutedEventArgs e)
        {
            PointLostFocus();
        }

        private void VitalityPoint_LostFocus(object sender, RoutedEventArgs e)
        {
            PointLostFocus();
        }

        private void IntellectPoint_LostFocus(object sender, RoutedEventArgs e)
        {
            PointLostFocus();
        }

        private void WitPoint_LostFocus(object sender, RoutedEventArgs e)
        {
            PointLostFocus();
        }

        private void CharismaPoint_LostFocus(object sender, RoutedEventArgs e)
        {
            PointLostFocus();
        }

        private void CSC_Checked(object sender, RoutedEventArgs e)
        {
            stats.SpasChec(CharismaSpas);
        }

        private void CSC_Unchecked(object sender, RoutedEventArgs e)
        {
            stats.SpasNoChec(CharismaSpas);
        }

        private void WSC_Checked(object sender, RoutedEventArgs e)
        {
            stats.SpasChec(WitSpas);
        }

        private void WSC_Unchecked(object sender, RoutedEventArgs e)
        {
            stats.SpasNoChec(WitSpas);
        }

        private void ISC_Checked(object sender, RoutedEventArgs e)
        {
            stats.SpasChec(IntellectSpas);
        }
        private void ISC_Unchecked(object sender, RoutedEventArgs e)
        {
            stats.SpasNoChec(IntellectSpas);
        }

        private void VSC_Checked(object sender, RoutedEventArgs e)
        {
            stats.SpasChec(VitalitySpas);
        }
        private void VSC_Unchecked(object sender, RoutedEventArgs e)
        {
            stats.SpasNoChec(VitalitySpas);
        }

        private void ASC_Checked(object sender, RoutedEventArgs e)
        {
            stats.SpasChec(AgilitySpas);
        }

        private void ASC_Unchecked(object sender, RoutedEventArgs e)
        {
            stats.SpasNoChec(AgilitySpas);
        }

        private void SSC_Checked(object sender, RoutedEventArgs e)
        {
            stats.SpasChec(StrengthSpas);
        }

        private void SSC_Unchecked(object sender, RoutedEventArgs e)
        {
            stats.SpasNoChec(StrengthSpas);
        }

        private void AKRSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (AKRSSB.IsChecked == true) { stats.SpasChec(AKRSS); }
        }

        private void ANASSB_Checked(object sender, RoutedEventArgs e)
        {
            if (ANASSB.IsChecked == true) { stats.SpasChec(ANASS); }
        }

        private void ATLSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (ATLSSB.IsChecked == true) { stats.SpasChec(ATLSS); }
        }

        private void VOSSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (VOSSSB.IsChecked == true) { stats.SpasChec(VOSSS); }
        }

        private void VYZSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (VYZSSB.IsChecked == true) { stats.SpasChec(VYZSS); }
        }

        private void VYSSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (VYSSSB.IsChecked == true) { stats.SpasChec(VYSSS); }
        }

        private void ZAPSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (ZAPSSB.IsChecked == true) { stats.SpasChec(ZAPSS); }
        }

        private void ISTSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (ISTSSB.IsChecked == true) { stats.SpasChec(ISTSS); }
        }

        private void LOVRSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (LOVRSSB.IsChecked == true) { stats.SpasChec(LOVRSS); }
        }

        private void MAGSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (MAGSSB.IsChecked == true) { stats.SpasChec(MAGSS); }
        }

        private void MEDSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (MEDSSB.IsChecked == true) { stats.SpasChec(MEDSS); }
        }

        private void OBMSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (OBMSSB.IsChecked == true) { stats.SpasChec(OBMSS); }
        }

        private void PRISSB_Checked(object sender, RoutedEventArgs e)
        {
            if (PRISSB.IsChecked == true) { stats.SpasChec(PRISS); }
        }

        private void PROSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (PROSSB.IsChecked == true) { stats.SpasChec(PROSS); }
        }

        private void RELSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (RELSSB.IsChecked == true) { stats.SpasChec(RELSS); }
        }

        private void SKRSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (SKRSSB.IsChecked == true) { stats.SpasChec(SKRSS); }
        }

        private void UBESSB_Checked(object sender, RoutedEventArgs e)
        {
            if (UBESSB.IsChecked == true) { stats.SpasChec(UBESS); }
        }

        private void UZZSSB_Checked(object sender, RoutedEventArgs e)
        {
            if (UZZSSB.IsChecked == true) { stats.SpasChec(UZZSS); }
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            TestText.Text = Convert.ToString(allBool.Lvl.Length);
        }
    }
}


