using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Door
    {
        public int height { get; set; }
        public Door(int h_Door) { height = h_Door; }
        public void Get_h()
        {
            Console.WriteLine($"vysota dveri: {height}");
        }
    }
}
