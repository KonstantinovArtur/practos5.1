
using practos5._1.ViewModel;
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
using System.Windows.Shapes;

namespace practos_5.View
{
    /// <summary>
    /// Логика взаимодействия для WindowOblivion.xaml
    /// </summary>
    public partial class WindowOblivion : Window
    {
        public WindowOblivion()
        {
            InitializeComponent();
            DataContext = new OblivionViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new Page1Oblivion();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page.Content = new Page2Oblivion();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Page.Content = new Page3Oblivion();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Page.Content = new Page4Oblivion();
        }
    }
}
