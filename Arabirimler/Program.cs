using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabirimler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape rect = new Rectangle(5, 8);
            Console.WriteLine(rect.CalculatePerimeter());
            IShape sqr = new Square(5);
            Console.WriteLine(sqr.CalculatePerimeter());
            IShape crc = new Circle(8);
            Console.WriteLine(crc.CalculatePerimeter());


        }
    }
}
