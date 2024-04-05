using practos5._1.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practos5._1.Model
{
    class Reg : BindingHelper
    {
        public Reg(string name)
        {
            Name = name;
            
        }

        public string Name { get; set; } = "Guest";
        
    }
}


