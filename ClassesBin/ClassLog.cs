using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.ClassesBin
{
    public class Warrior : ClassStats
    {
        private string _name    = "Воин";
        private int _hit        = 10;
        private string _armor   = "Все доспехи, Щиты";
        private string _weapon  = "Простое оружие, воинское оружие";
        private string? _tool   = null;
        private string _spas    = "Сила, Телосложение";
        private string _skill   = "Акробатика, Атлетика, Восприятие, Выживание, Запугивание, История, Проницательность, Уход за животными";
        public override string ClassName { get { return _name; } set { _name = value; } }
        public override int HitDice { get { return _hit; } set => _hit = value; }
        public override string OwnershipArmor { get => _armor; set => _armor = value; }
        public override string OwnershipWeapon { get => _weapon; set => _weapon = value; }
        public override string? OwnershipTool { get => _tool; set => _tool = value; }
        public override string OwnershipSpas { get => _spas; set => _spas = value; }
        public override string OwnershipSkill { get => _skill; set => _skill = value; }
    }

    public class Rogue : ClassStats
    {
        private string _name = "Плут";
        private int _hit = 8;
        private string _armor = "Лёгкие доспехи";
        private string _weapon = "Простое оружие, ручные арбалеты, длинные мечи, рапиры, короткие мечи";
        private string? _tool = "Воровские инструменты";
        private string _spas = "Ловкость, Интеллект";
        private string _skill = "Акробатика, Атлетика, Восприятие, Выступление, Запугивание, Ловкость рук, Обман, Проницательность, Расследование, Скрытность, Убеждение";
        public override string ClassName { get { return _name; } set { _name = value; } }
        public override int HitDice { get { return _hit; } set => _hit = value; }
        public override string OwnershipArmor { get => _armor; set => _armor = value; }
        public override string OwnershipWeapon { get => _weapon; set => _weapon = value; }
        public override string? OwnershipTool { get => _tool; set => _tool = value; }
        public override string OwnershipSpas { get => _spas; set => _spas = value; }
        public override string OwnershipSkill { get => _skill; set => _skill = value; }
    }
}
