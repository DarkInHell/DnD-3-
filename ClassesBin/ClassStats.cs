using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class ClassStats
    {
        private string _className;
        private int    _hitDice;
        private string _ownershipArmor;
        private string _ownershipWeapon;
        private string _ownershipTool;
        private string _ownershipSpas;
        private string _ownershipSkill;

        public string ClassName         { get { return _className; }        set { _className = value; } }
        public int    HitDice           { get { return _hitDice; }          set { _hitDice = value; } }
        public string OwnershipArmor    { get { return _ownershipArmor; }   set { _ownershipArmor = value; } }
        public string OwnershipWeapon   { get { return _ownershipWeapon; }  set { _ownershipWeapon = value; } }
        public string OwnershipTool     { get { return _ownershipTool; }    set { _ownershipTool = value; } }
        public string OwnershipSpas     { get { return _ownershipSpas; }    set { _ownershipSpas = value; } }
        public string OwnershipSkill    { get { return _ownershipSkill; }   set { _ownershipSkill = value; } }
    }
}
