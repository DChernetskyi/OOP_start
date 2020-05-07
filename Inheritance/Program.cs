using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skoda skoda = new Skoda();
            Fabia fabia = new Fabia(1200,4);
            fabia.GetInfo();
            fabia.PostavitKoleso();
            Console.ReadLine();
        }
    }
}
