using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DnD.RacesBin
{
    public class Human : RaceStats
    {
        public Human()
        {
            PointStr = 1;
            PointDex = 1;
            PointVit = 1;
            PointWit = 1;
            PointInt = 1;
            PointCha = 1;

            NameRace = "Человек";
            Speed = 30;
            Lang = "Общий + 1";

            NameAbility = new string[] { "Навык+", "Черта+" };
            DescriptionAbility = new string[] { "Вы получаете владение одним навыком на ваш выбор", "Вы получаете одну черту на ваш выбор" };
        }
    }
}
