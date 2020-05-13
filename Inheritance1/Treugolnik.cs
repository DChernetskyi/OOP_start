using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Treugolnik : Figura
    {
        public int gipotenuza { set; get; }
        public int katet1 { set; get; }
        public int katet2 { set; get; }
        public Treugolnik(int gip, int kat1, int kat2, int koord_x, int koord_y)
            :base(koord_x, koord_y)
        {
            gipotenuza = gip;
            katet1 = kat1;
            katet2 = kat2;

        }
        public void GetTreugolnik()
        {
            Console.WriteLine($"storona1: {gipotenuza}, storona2: {katet1}, storona3: {katet2}, koordinata x: {x}, koordinata y: {y}");
            
        }


    }
}
