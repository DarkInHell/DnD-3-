using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.ClassesBin
{
    public class Classes : ClassStats
    {
        public Classes( string _ClassName, 
                        int _HitDice, 
                        string _OwnershipArmor,
                        string _OwnershipWeapon,
                        string _OwnershipTool ,
                        string _OwnershipSpas ,
                        string _OwnershipSkill )
        {
            ClassName       = _ClassName;
            HitDice         = _HitDice;
            OwnershipArmor  = _OwnershipArmor;
            OwnershipWeapon = _OwnershipWeapon;
            OwnershipTool   = _OwnershipTool;
            OwnershipSpas   = _OwnershipSpas;
            OwnershipSkill  = _OwnershipSkill;
        }
    }
}
