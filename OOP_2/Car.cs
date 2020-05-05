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
        public Motor motor;
        
        public Car(string markaAvto,int ageAvto, Motor motor_obg) { marka = markaAvto; age = ageAvto; motor = motor_obg; }
        public void GetInfo()
        {
            Console.WriteLine($"марка: {marka}, возраст: {age}, мотор: {motor.type}");
        }
    }
}
