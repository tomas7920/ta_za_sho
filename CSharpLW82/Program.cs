using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLW82
{
    class Program
    {
        static void Main(string[] args)
        {
            Glass glasses = new Glass("");

            ColorScreen phone = new ColorScreen("");

            glasses.GetName();

            phone.GetName();

            Console.ReadLine();
        }
    }
}
