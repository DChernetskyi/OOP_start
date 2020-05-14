using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism_pereopredelenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Voin_v_dospehah voin_V_Dospehah = new Voin_v_dospehah(100);
            voin_V_Dospehah.poluchit_uron(10);
            Voin_bez_dospeh voin_Bez_Dospeh = new Voin_bez_dospeh(100);
            voin_Bez_Dospeh.poluchit_uron(10);
            Console.ReadLine();
        }
    }
}
