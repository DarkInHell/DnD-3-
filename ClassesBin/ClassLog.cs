using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.ClassesBin
{
    public class ClassLog
    {
        public Classes Warrior()
        {
            Classes Warrior = new("Воин",
                                  10,
                                  "Все доспехи, Щиты",
                                  "Простое оружие, воинское оружие",
                                  null,
                                  "Сила, Телосложение",
                                  "Акробатика, Атлетика, Восприятие, Выживание, Запугивание, " +
                                  "История, Проницательность, Уход за животными");
            return Warrior;
        }

        public Classes Rogue()
        {
            Classes Rogue = new("Плут",
                                8,
                                "Лёгкие доспехи",
                                "Простое оружие, ручные арбалеты, длинные мечи, рапиры, короткие мечи",
                                "Воровские инструменты",
                                "Ловкость, Интеллект",
                                "Акробатика, Атлетика, Восприятие, Выступление, Запугивание, " +
                                "Ловкость рук, Обман, Проницательность, Расследование, Скрытность, Убеждение");
            return Rogue;
        }
    }
}