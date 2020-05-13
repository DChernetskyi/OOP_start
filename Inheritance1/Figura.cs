using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Figura
    {
        public int x { set; get; }
        public int y { set; get; }
        public Figura(int koord_x, int koord_y) { x = koord_x; y = koord_y; }
        public void narisovat()
        {
            Console.WriteLine("NARISOVALI FIGURU");
        }
    }
}
