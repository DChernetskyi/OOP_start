using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Fabia : Skoda
    {
        public int ves { get; set; }

        public Fabia(int kg, int kol) 
            : base(kol)
        { 
            ves = kg;
        }
        public void GetInfo()
        {
            Console.WriteLine($"ves: {ves}, koleso: {Koleso} ");
        }
        
    }
}
