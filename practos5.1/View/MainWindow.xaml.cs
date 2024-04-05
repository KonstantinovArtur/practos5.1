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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace practos5._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
        string x = "Guest";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Avt.IsEnabled = true;
 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Avt.Text == x)
            {
                D.IsEnabled = true;
                W.IsEnabled = true;
                O.IsEnabled = true;
                C.IsEnabled = true;
                RR.Text = " ";
            }
            else if (Avt.Text != x )
            {
                RR.Text = "Логин не совпадает ";
            }
        }
    }
}
