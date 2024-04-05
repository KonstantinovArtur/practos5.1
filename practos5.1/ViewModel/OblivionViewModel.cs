using practos5._1.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace practos5._1.ViewModel
{
    class OblivionViewModel : BindingHelper
    {
        public BindableCommand bak { get; set; }
        public void back1()
        {
            MainWindow second_window = new MainWindow();
            second_window.Show();
            Application.Current.Windows[0].Close();




        }

        public OblivionViewModel()
        {

            bak = new BindableCommand(_ => back1());


        }
    }
}
