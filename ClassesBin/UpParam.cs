using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DnD
{
    public class UpParam : AllVariable
    {
        public string Ownership(ComboBox comboBox, TextBlock list)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            try
            {
                string ClassText = comboBox.Text;
                if (ClassText == _warrior.ClassName)
                {
                    list.Text = _warrior.OwnershipArmor + "   " + _warrior.OwnershipWeapon;
                    return list.Text;
                }
                else if (ClassText == _rogue.ClassName)
                {
                    list.Text = _rogue.OwnershipArmor + "   " +  _rogue.OwnershipWeapon;
                    return list.Text;
                }
            }
            catch { }

            return list.Text;
        }
    }
}
