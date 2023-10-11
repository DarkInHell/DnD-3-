using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DnD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Frame.Navigate(new ChapList());
        }

        private void List_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(new ChapList());
        }

        private void Map_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Spell_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
