using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class House
    {
        public Window window { get; set; }
        public Door door { get; set; }
        public int price { get; set; }
        public House(Window windowColor, Door door_H, int priceHouse) { window = windowColor; door = door_H; price = priceHouse; }
        public void Get_Info()
        {
            Console.WriteLine($"okno: {window.Color}, dveri: {door.height}, tsena: {price}");

        }

    }
}
