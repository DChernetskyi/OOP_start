using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Treugolnik treugolnik = new Treugolnik(10, 7, 5, 150, 240);
            treugolnik.narisovat();
            treugolnik.GetTreugolnik();
            Krug krug = new Krug(50, 50, 79);
            krug.narisovat();
            krug.GetKrug();
            Console.ReadLine();


        }
    }
}
