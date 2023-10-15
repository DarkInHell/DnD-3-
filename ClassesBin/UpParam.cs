using System.Windows.Controls;

namespace DnD
{
    public class UpParam : AllVariable
    {
        public string Ownership(ComboBox comboBox, TextBox list)
        {
            try
            {
                string Class = comboBox.Text;
                if (Class == _warrior.ClassName)
                {
                    list.Text = "Броня: " + _warrior.OwnershipArmor + "\r\n" + "Оружие: " + _warrior.OwnershipWeapon + "\r\n" + "Инструменты: " + _warrior.OwnershipTool;
                    return list.Text;
                }
                else if (Class == _rogue.ClassName)
                {
                    list.Text = "Броня: " + _rogue.OwnershipArmor + "\r\n" + "Оружие: " + _rogue.OwnershipWeapon + "\r\n" + "Инструменты: " + _rogue.OwnershipTool;
                    return list.Text;
                }
            }
            catch { }

            return list.Text;
        }
    }
}
