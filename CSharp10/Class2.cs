using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    static class Class2
    {
        public static void DisplayList(this Class1 array)
        {

            Console.WriteLine("\nЭлементы с парной позицией:");

            for (int i = 0; i < array.Size; i++)
            {
                if (i % 2 == 0)
                {
                    array.DisplayElement(i);
                }
            }

            Console.WriteLine("\nЭлементы с непарной позицией:");

            for (int i = 0; i < array.Size; i++)
            {
                if (i % 2 != 0)
                {
                    array.DisplayElement(i);
                }
            }
        }
    }
}