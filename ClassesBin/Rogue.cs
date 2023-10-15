using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.ClassesBin
{
    public class Rogue : ClassStats
    {
        public Rogue()
        {
            ClassName = "Плут";
            HitDice = 8;
            OwnershipArmor = "Лёгкие_доспехи";
            OwnershipWeapon = "Простое_оружие, ручные_арбалеты, длинные_мечи, рапиры, короткие_мечи";
            OwnershipTool = "Воровские_инструменты";
            OwnershipSpas = "Ловкость, Интеллект";
            OwnershipSkill = "Акробатика, Атлетика, Восприятие, Выступление, Запугивание, Ловкость_рук, Обман, Проницательность, Расследование, Скрытность, Убеждение";
        }
    }
}
