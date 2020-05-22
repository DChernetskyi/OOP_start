using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Tv : ISwitchable
    {
        public void Off()
        {
            Console.WriteLine("Телевизор выключился");
        }

        public void On()
        {
            Console.WriteLine("Телевизор включился");
        }
    }
}
