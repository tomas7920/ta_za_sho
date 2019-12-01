using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 list = new Class1();
            for (int i = 0; i < 10; i++)
            {
                list.AddElement();
            }

            Class2.DisplayList(list);

            Console.ReadKey();
        }
    }
}