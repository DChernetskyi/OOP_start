using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Skoda
        {
            Fabia = 13000,
            Octavia = 17000,
            SuperB = 25000
        }

        static void PriceModel(Skoda Sk)
        {
            int price = 0;
            switch (Sk)
            {
                case Skoda.Fabia:
                    price += (int)Skoda.Fabia;
                    Console.WriteLine("Price Fabia " + price + " USD");
                    break;

                case Skoda.Octavia:
                    price += (int)Skoda.Octavia;
                    Console.WriteLine("Price Octavia " + price + " USD");
                    break;
                case Skoda.SuperB:
                    price += (int)Skoda.SuperB;
                    Console.WriteLine("Price SuperB " + price + " USD");
                    break;
            }

            
        }
        
        static void Main(string[] args)
        {
            PriceModel(Skoda.Fabia);
            PriceModel(Skoda.Octavia);
            PriceModel(Skoda.SuperB);
            Console.ReadLine();
        }
    }
}
