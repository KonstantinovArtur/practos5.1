using practos_5.View;
using practos5._1.View;
using practos5._1.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace practos5._1.ViewModel
{
    class WitcherViewModel : BindingHelper
    {
        public BindableCommand bac { get; set; }
        
        
          

        public void back()
        {
            MainWindow second_window = new MainWindow();
            second_window.Show();
            Application.Current.Windows[0].Close();



      
    }
        
        public WitcherViewModel()
        {

            bac = new BindableCommand(_ => back());
            

        }
    }
}
