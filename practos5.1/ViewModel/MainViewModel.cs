using practos_5.View;
using practos5._1.Model;
using practos5._1.View;
using practos5._1.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;

namespace practos5._1.ViewModel
{
    internal class MainViewModel : BindingHelper
    {
        public BindableCommand Wit { get; set; }
        public BindableCommand Obl { get; set; }
        public BindableCommand Div { get; set; }
        public BindableCommand Cyb { get; set; }
      






        public void Witi()
        {
            WindowWitcher second_window = new WindowWitcher();
            second_window.Show();
            Application.Current.MainWindow.Close();

        }
        public void Obli()
        {
            WindowOblivion second_window = new WindowOblivion();
            second_window.Show();
            Application.Current.MainWindow.Close();
        }
        public void Divi()
        {
            WindowDivinity second_window = new WindowDivinity();
            second_window.Show();
            Application.Current.MainWindow.Close();

        }
        public void Cybe()
        {
            WindowCyberpunk second_window = new WindowCyberpunk();
            second_window.Show();
            Application.Current.MainWindow.Close();
        }
        public MainViewModel()
        {

            Wit = new BindableCommand(_ => Witi());
            Obl = new BindableCommand(_ => Obli());
            Div = new BindableCommand(_ => Divi());
            Cyb = new BindableCommand(_ => Cybe());
            
        }

    }

}
