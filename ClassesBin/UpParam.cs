using DnD.ClassesBin;
using System.Windows.Controls;

namespace DnD
{
    public class UpParam : AllVariable
    {
        public string Ownership(ComboBox comboBox, TextBox list)
        {
            ClassLog classLog = new ClassLog();
            try
            {
                string Class = comboBox.Text;
                if (Class == classLog.Warrior().ClassName)
                {
                    list.Text = "Броня: " + classLog.Warrior().OwnershipArmor + "\r\n" + "Оружие: " + classLog.Warrior().OwnershipWeapon + "\r\n" + "Инструменты: " + classLog.Warrior().OwnershipTool;
                    return list.Text;
                }
                else if (Class == classLog.Rogue().ClassName)
                {
                    list.Text = "Броня: " + classLog.Rogue().OwnershipArmor + "\r\n" + "Оружие: " + classLog.Rogue().OwnershipWeapon + "\r\n" + "Инструменты: " + classLog.Rogue().OwnershipTool;
                    return list.Text;
                }
            }
            catch { }

            return list.Text;
        }
    }
}
