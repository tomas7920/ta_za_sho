using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLW3
{
    //Лаба №3, Завдання №7
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.Write("c: ");
            int c = Int32.Parse(Console.ReadLine());

            if (a == b || a == c || b == c)
            {
                Console.WriteLine("Є хоча б одна пара однакових чисел.");
            }
            else
            {
                Console.WriteLine("Жодної пари немає.");
            }

            Console.ReadLine();
        }
    }
}