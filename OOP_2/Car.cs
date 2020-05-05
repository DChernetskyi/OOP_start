using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class Car
    {
        public string marka;
        public int age;
        public Car() { marka = "audi"; age = 7; }
        public void GetInfo()
        {
            Console.WriteLine($"марка: {marka}, возраст: {age}");
        }
    }
}
