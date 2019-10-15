using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLW1
{
    //Лаба №1, Завдання №5
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 Резистор: ");
            int R1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 Резистор: ");
            int R2 = Convert.ToInt32(Console.ReadLine());

            int Opora = (R1 * R2) / (R1 + R2);
            Console.WriteLine("Наша Опора = " + Opora);

            Console.ReadLine();
        }
    }
}
