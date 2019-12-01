using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLW9
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s;
            s = Square.InputData();
            s.Draw();

            Triangle t;
            t = Triangle.InputData();
            t.Draw();

            Circle c;
            c = Circle.InputData();
            c.Draw();

            Console.ReadKey();
        }
    }
}
