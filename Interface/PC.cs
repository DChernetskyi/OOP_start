using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class PC : ISwitchable
    {
        public void Off()
        {
            Console.WriteLine("ПК выключился");
        }

        public void On()
        {
            Console.WriteLine("ПК включился");
        }
    }
}
