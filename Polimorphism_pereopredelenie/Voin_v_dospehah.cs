using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism_pereopredelenie
{
    class Voin_v_dospehah : Voin
    {

        public Voin_v_dospehah(int life)
            : base(life)
        { 
        }
        public override void poluchit_uron(int x)
        {
            int ostatok_gizni = life - x / 2;
            Console.WriteLine("voin_v_dospehah\n" + ostatok_gizni);
        }
    }
}
