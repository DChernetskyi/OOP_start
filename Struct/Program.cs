using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Circle
    {
        public double L;
        public Circle(double L)
        {
            this.L = L;
        }
        public double Radius()
        {
            double R = (L / (2 * 3.14));
            return R;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(25);
            
            Console.WriteLine(circle.Radius());


            Console.ReadLine();
        }
    }
}
