namespace DnD.ClassesBin
{
    public class Warrior : ClassStats
    {
        public Warrior() 
        {
            _className          = "Воин";
            _hitDice            = 10;
            _ownershipArmor     = "Все доспехи, Щиты";
            _ownershipWeapon    = "Простое оружие, воинское оружие";
            _ownershipTool      = null;
            _ownershipSpas      = "Сила, Телосложение";
            _ownershipSkill     = "Акробатика, Атлетика, Восприятие, Выживание, Запугивание, История, Проницательность, Уход за животными";
            _skillValue         = 2;
        }                       

    }

    public class Rogue : ClassStats
    {
        public Rogue()
        {
            _className       = "Плут";
            _hitDice         = 8;
            _ownershipArmor  = "Лёгкие доспехи";
            _ownershipWeapon = "Простое оружие, ручные арбалеты, длинные мечи, рапиры, короткие мечи";
            _ownershipTool   = "Воровские инструменты";
            _ownershipSpas   = "Ловкость, Интеллект";
            _ownershipSkill  = "Акробатика, Атлетика, Восприятие, Выступление, Запугивание, Ловкость рук, Обман, Проницательность, Расследование, Скрытность, Убеждение";
            _skillValue      = 4;
        }

    }
}
