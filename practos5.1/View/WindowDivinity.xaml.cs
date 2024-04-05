﻿
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
    /// Логика взаимодействия для WindowDivinity.xaml
    /// </summary>
    public partial class WindowDivinity : Window
    {
        public WindowDivinity()
        {
            InitializeComponent();
            DataContext = new DivinityViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new Page1Divinity();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page.Content = new Page2Divinity();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Page.Content = new Page3Divinity();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Page.Content = new Page4Divinity();
        }
    }
}
