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
            Motor motor = new Motor();
            motor.type = "diesel";
            Car car = new Car("BMW", 5, motor);
                  
            
            car.GetInfo();
            Console.ReadLine();
        }
    }
}
