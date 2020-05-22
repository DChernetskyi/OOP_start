using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISwitchable> switchables = new List<ISwitchable>();
            switchables.Add(new PC());
            switchables.Add(new Tv());
            foreach (ISwitchable switchable in switchables)
            {
                switchable.Off();
                switchable.On();
            }

                       
            Console.ReadLine();

        }
    }
}
