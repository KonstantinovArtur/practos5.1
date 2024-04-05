using practos5._1.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace practos5._1.ViewModel
{
    class DivinityViewModel : BindingHelper
    {
        public BindableCommand bakk { get; set; }
        public void back2()
        {
            MainWindow second_window = new MainWindow();
            second_window.Show();
            Application.Current.Windows[0].Close();




        }

        public DivinityViewModel()
        {

            bakk = new BindableCommand(_ => back2());


        }
    }
}
