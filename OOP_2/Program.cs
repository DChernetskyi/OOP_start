using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.GetInfo();
            car.age = 50;
            car.marka = "BMW";
            car.GetInfo();
            Console.ReadLine();
        }
    }
}
