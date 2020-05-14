using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism_pereopredelenie
{
    class Voin
    {
        public int life { set; get; }
        public Voin(int life) { this.life = life; }
        public virtual void poluchit_uron(int x)
        {
            Console.WriteLine(life-x);
        }

    }
}
