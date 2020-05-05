using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window();
            window.Color = "white";
            Door door = new Door(240);
            
            House house = new House(window, door, 200000);
            house.door.Get_h();
            
            house.Get_Info();
            Console.ReadLine();

        }
    }
}
