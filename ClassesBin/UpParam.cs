using DnD.ClassesBin;
using System;
using System.Windows;
using System.Windows.Controls;
using static DnD.AllVariable;

namespace DnD
{
    public class UpParam
    {
        public string Ownership(ComboBox comboBox, TextBox list)
        {
            //ClassStats[] listClass = new ClassStats[] { new Warrior(), new Rogue() };
            try
            {
                foreach (ClassStats c in Classes)
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
