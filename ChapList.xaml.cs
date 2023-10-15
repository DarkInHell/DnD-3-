using DnD.ClassesBin;
using DnD.RacesBin;
using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace DnD
{
    public partial class ChapList : Page
    {
        public ChapList()
        {
            InitializeComponent();
            DataContext = new ChoseRaces();
        }

        #region Fabric

        private Stats stats = new Stats();
        private UpParam upParam = new UpParam();


        private void LvlBox_LostFocus(object sender, RoutedEventArgs e)
        {
            Level level = new Level();
            level.LevelEnc(LvlBlock, LvlBox);
            stats.MasterBool = true;
            MasterAssign();
        }

        public void MasterAssign()
        {
            if (stats.MasterBool == true)
            {
                MasterNum.Text = "+" + stats.MasterEnc(LvlBox);
                stats.MasterBool = false;
            }
        }

        public void StatsPointEnc()
        {

            string s = Convert.ToString(stats.StatsEnc(StrengthPoint));
            stats.TextString(StrengthStats, StrengthSpas, ATLSS, null, s);

            string a = Convert.ToString(stats.StatsEnc(AgilityPoint));
            stats.TextString(AgilityStats, AgilitySpas, AKRSS, LORSS, a);
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

        }

        public void PointLostFocus()
        {
            StatsPointEnc();
        }

        #endregion

        #region MainStats

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
            stats.RaceBonus(RaceCombo, ListSkill, StrengthPoint, AgilityPoint, VitalityPoint, IntellectPoint, WitPoint, CharismaPoint);
            PointLostFocus();
        }

        #endregion

        #region SpasStats

        private void CSC_CU (object sender, RoutedEventArgs e)
        {
            CharismaSpas.Text = stats.Check_Uncheck(CharismaSpas, CSC);
        }

        private void WSC_CU(object sender, RoutedEventArgs e)
        {
            WitSpas.Text = stats.Check_Uncheck(WitSpas, WSC);
        }

        private void ISC_CU(object sender, RoutedEventArgs e)
        {
            IntellectSpas.Text = stats.Check_Uncheck(IntellectSpas, ISC);
        }
        private void ISC_Unchecked(object sender, RoutedEventArgs e)
        {
            stats.SpasNoChec(IntellectSpas);
        }

        private void VSC_CU(object sender, RoutedEventArgs e)
        {
            VitalitySpas.Text = stats.Check_Uncheck(VitalitySpas, VSC);
        }
        private void VSC_Unchecked(object sender, RoutedEventArgs e)
        {
            stats.SpasNoChec(VitalitySpas);
        }

        private void ASC_CU(object sender, RoutedEventArgs e)
        {
            AgilitySpas.Text = stats.Check_Uncheck(AgilitySpas, ASC);
        }

        private void SSC_CU(object sender, RoutedEventArgs e)
        {
            StrengthSpas.Text = stats.Check_Uncheck(StrengthSpas, SSC);
        }

        #endregion

        #region SubStats

        private void AKRSSB_CU(object sender, RoutedEventArgs e)
        {
            AKRSS.Text = stats.Check_Uncheck(AKRSS, AKRSSB);
        }

        private void ANASSB_CU(object sender, RoutedEventArgs e)
        {
            ANASS.Text = stats.Check_Uncheck(ANASS, ANASSB);
        }

        private void ATLSSB_CU(object sender, RoutedEventArgs e)
        {
            ATLSS.Text = stats.Check_Uncheck(ATLSS, ATLSSB);
        }

        private void VOSSSB_CU(object sender, RoutedEventArgs e)
        {
            VOSSS.Text = stats.Check_Uncheck(VOSSS, VOSSSB);
        }

        private void VYZSSB_CU(object sender, RoutedEventArgs e)
        {
            VYZSS.Text = stats.Check_Uncheck(VYZSS, VYZSSB);
        }

        private void VYSSSB_CU(object sender, RoutedEventArgs e)
        {
            VYSSS.Text = stats.Check_Uncheck(VYSSS, VYSSSB);
        }

        private void ZAPSSB_CU(object sender, RoutedEventArgs e)
        {
            ZAPSS.Text = stats.Check_Uncheck(ZAPSS, ZAPSSB);
        }

        private void ISTSSB_CU(object sender, RoutedEventArgs e)
        {
            ISTSS.Text = stats.Check_Uncheck(ISTSS, ISTSSB);
        }

        private void LORSSB_CU(object sender, RoutedEventArgs e)
        {
            LORSS.Text = stats.Check_Uncheck(LORSS, LORSSB);
        }

        private void MAGSSB_CU(object sender, RoutedEventArgs e)
        {
            MAGSS.Text = stats.Check_Uncheck(MAGSS, MAGSSB);
        }

        private void MEDSSB_CU(object sender, RoutedEventArgs e)
        {
            MEDSS.Text = stats.Check_Uncheck(MEDSS, MEDSSB);
        }

        private void OBMSSB_CU(object sender, RoutedEventArgs e)
        {
            OBMSS.Text = stats.Check_Uncheck(OBMSS, OBMSSB);
        }

        private void PRISSB_CU(object sender, RoutedEventArgs e)
        {
            PRISS.Text = stats.Check_Uncheck(PRISS, PRISSB);
        }

        private void PROSSB_CU(object sender, RoutedEventArgs e)
        {
            PROSS.Text = stats.Check_Uncheck(PROSS, PROSSB);
        }

        private void RELSSB_CU(object sender, RoutedEventArgs e)
        {
            RELSS.Text = stats.Check_Uncheck(RELSS, RELSSB);
        }

        private void SKRSSB_CU(object sender, RoutedEventArgs e)
        {
            SKRSS.Text = stats.Check_Uncheck(SKRSS, SKRSSB);
        }

        private void UBESSB_CU(object sender, RoutedEventArgs e)
        {
            UBESS.Text = stats.Check_Uncheck(UBESS, UBESSB);
        }

        private void UZZSSB_CU(object sender, RoutedEventArgs e)
        {
            UZZSS.Text = stats.Check_Uncheck(UZZSS, UZZSSB);
        }

        #endregion

        private void ClassCombo_LostFocus(object sender, RoutedEventArgs e)
        {
            upParam.Ownership(ClassCombo, ListSkill);
        }

        private void RaceCombo_GotFocus(object sender, RoutedEventArgs e)
        {
        }

    }
}