using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.name = "Monika";
            cat.GetInfo();
            cat.name = "Barsik";
            cat.GetInfo();
            Console.ReadLine();
        }
    }
}
