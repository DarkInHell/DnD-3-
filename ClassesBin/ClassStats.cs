using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.ClassesBin
{
    public abstract class ClassStats
    {
        private string _className;
        private int _hitDice;
        private string _ownershipArmor;
        private string _ownershipWeapon;
        private string _ownershipSpas;
        private string _ownershipSkill;

        public virtual string ClassName { get { return _className; } set { _className = value; } }
        public virtual int HitDice { get { return _hitDice; } set { _hitDice = value; } }
        public virtual string OwnershipArmor { get { return _ownershipArmor; } set { _ownershipArmor = value; } }
        public virtual string OwnershipWeapon { get { return _ownershipWeapon; } set { _ownershipWeapon = value; } }
        public virtual string OwnershipSpas { get { return _ownershipSpas; } set { _ownershipSpas = value; } }
        public virtual string OwnershipSkill { get { return _ownershipSkill; } set { _ownershipSkill = value; } }
        #nullable enable
        private string? _ownershipTool;
        public virtual string? OwnershipTool { get { return _ownershipTool; } set { _ownershipTool = value; } }

    }
}
