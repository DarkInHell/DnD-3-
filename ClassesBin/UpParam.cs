using DnD.ClassesBin;
using System;
using System.Windows;
using System.Windows.Controls;

namespace DnD
{
    public class UpParam : AllVariable
    {
        public string Ownership(ComboBox comboBox, TextBox list)
        {
            ClassStats[] classes = new ClassStats[] { new Warrior(), new Rogue() };
            try
            {
                foreach (ClassStats c in classes)
                {
                    if (comboBox.Text == c.ClassName)
                    {
                        list.Text = "Броня: " + c.OwnershipArmor + "\r\n" + "Оружие: " + c.OwnershipWeapon + "\r\n" + "Инструменты: " + c.OwnershipTool;
                        return list.Text;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            return list.Text;
        }
    }
}
