using DnD.Manager;
using System.Windows;
using System.Windows.Controls;

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
            Frame.Navigate(FrameManager.OnlyOneChapList());
            FrameManager.Frame = Frame;
        }

        private void List_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.Frame.NavigationService.Navigate(FrameManager.OnlyOneChapList());
        }

        private void Map_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.Frame.NavigationService.Navigate(FrameManager.OnlyOneMapList());
        }

        private void Spell_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
