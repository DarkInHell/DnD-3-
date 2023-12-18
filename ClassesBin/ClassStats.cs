namespace DnD.ClassesBin
{
    public abstract class ClassStats
    {
        protected string _className;
        protected int    _hitDice;
        protected string _ownershipArmor;
        protected string _ownershipWeapon;
        protected string _ownershipSpas;
        protected string _ownershipSkill;
        protected int    _skillValue;

        public string ClassName { get { return _className; } set { _className = value; } }
        public int HitDice { get { return _hitDice; } set { _hitDice = value; } }
        public string OwnershipArmor { get { return _ownershipArmor; } set { _ownershipArmor = value; } }
        public string OwnershipWeapon { get { return _ownershipWeapon; } set { _ownershipWeapon = value; } }
        public string OwnershipSpas { get { return _ownershipSpas; } set { _ownershipSpas = value; } }
        public string OwnershipSkill { get { return _ownershipSkill; } set { _ownershipSkill = value; } }
        public int SkillValue { get { return _skillValue; } set { _skillValue = value; } }
#nullable enable
        protected string? _ownershipTool;
        public string? OwnershipTool { get { return _ownershipTool; } set { _ownershipTool = value; } }

    }
}
