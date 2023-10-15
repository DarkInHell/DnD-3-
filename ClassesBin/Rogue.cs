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
            OwnershipArmor = "Лёгкие доспехи";
            OwnershipWeapon = "Простое оружие, ручные арбалеты, длинные мечи, рапиры, короткие мечи";
            OwnershipTool = "Воровские инструменты";
            OwnershipSpas = "Ловкость, Интеллект";
            OwnershipSkill = "Акробатика, Атлетика, Восприятие, Выступление, Запугивание, Ловкость рук, Обман, Проницательность, Расследование, Скрытность, Убеждение";
        }
    }
}
