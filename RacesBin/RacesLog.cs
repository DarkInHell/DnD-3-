using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.RacesBin
{
    public class RacesLog
    {
        public class Human : RaceStats
        {
            private int[] point = new int[] { 1, 1, 1, 1, 1, 1};
            private string name = "Человек";
            private int speed = 30;
            private string lang = "Общий + 1";
            private string[] nameAbility = new string[] { "Навык+", "Черта+" };
            private string[] descriptionAbility = new string[] { "Вы получаете владение одним навыком на ваш выбор", "Вы получаете одну черту на ваш выбор" };
                          
            public override int[] Point { get => point; set => point = value; }
            public override string NameRace { get => name; set => name = value; }
            public override int Speed { get => speed; set => speed = value; }
            public override string Lang { get => lang; set => lang = value; }
            public override string[] NameAbility { get => nameAbility; set => nameAbility = value; }
            public override string[] DescriptionAbility { get => descriptionAbility; set => descriptionAbility = value; }
        }

        public class Elf : RaceStats 
        {
            private int[] point = new int[] { 0, 2, 0, 0, 0, 0 };
            private string name = "Эльф";
            private int speed = 30;
            private string lang = "Общий, Эльфийский";
            private string[] nameAbility = new string[] { "Тёмное зрение", "Обострённые чувства", "Наследие фей", "Транс" };
            private string[] descriptionAbility = new string[] { "Привыкнув к сумраку леса и ночному небу, вы обладаете превосходным зрением в темноте и при тусклом освещении. " +
                               "На расстоянии в 60 футов вы при тусклом освещении можете видеть так, как будто это яркое освещение, и в темноте так, как будто это тусклое освещение. " +
                               "В темноте вы не можете различать цвета, только оттенки серого",
                               "Вы владеете навыком Восприятие", "Вы совершаете с преимуществом спасброски от состояния «очарованный», и вас невозможно магически усыпить.",
                               "Эльфы не спят. Вместо этого они погружаются в глубокую медитацию, находясь в полубессознательном состоянии до 4 часов в сутки (обычно такую медитацию называют трансом). " +
                               "Во время этой медитации вы можете грезить о разных вещах. Некоторые из этих грёз являются ментальными упражнениями, выработанными за годы тренировок. " +
                               "После такого отдыха вы получаете все преимущества, которые получает человек после 8 часов сна."};
            public override int[] Point { get => point; set => point = value; }
            public override string NameRace { get => name; set => name = value; }
            public override int Speed { get => speed; set => speed = value; }
            public override string Lang { get => lang; set => lang = value; }
            public override string[] NameAbility { get => nameAbility; set => nameAbility = value; }
            public override string[] DescriptionAbility { get => descriptionAbility; set => descriptionAbility = value; }
        }
    }
}
