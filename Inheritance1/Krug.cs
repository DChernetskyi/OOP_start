using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Krug : Figura
    {
        public int diametr { set; get; }
        public Krug(int diam, int koord_x, int koord_y)
            : base(koord_x, koord_y)
        {
            diametr = diam;
        }
        public void GetKrug()
        {
            Console.WriteLine($"okrugnost: {diametr}, koordinatu: {x},koordinata y: {y}");
        }

    }
}
