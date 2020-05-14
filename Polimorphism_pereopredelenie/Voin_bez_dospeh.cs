using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism_pereopredelenie
{
    class Voin_bez_dospeh : Voin
    {
        public Voin_bez_dospeh(int life)
            : base(life)
        { 
        }
        public override void poluchit_uron(int x)
        {
            int ostatok_gizni = life - x * 2;
            Console.WriteLine("voin_bez_dospeh\n" + ostatok_gizni);
        }
    }
}
