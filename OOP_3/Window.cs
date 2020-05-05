using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Window
    {
        private string color;
        public string Color
        {
            set
            {
                color = value;  
            }
            get
            {
                return color;
            }
        }
    }
}
