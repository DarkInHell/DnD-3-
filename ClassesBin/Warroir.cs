using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class Warrior : ClassStats
    {
        public Warrior()
        {
            ClassName = "Воин";
            HitDice = 10;
            OwnershipArmor = "Все_доспехи, Щиты";
            OwnershipWeapon = "Простое_оружие, воинское_оружие";
            OwnershipTool = null;
            OwnershipSpas = "Сила, Телосложение";
            OwnershipSkill = "Акробатика, Атлетика, Восприятие, Выживание, Запугивание, История, Проницательность, Уход_за_животными";
        }

    }
}