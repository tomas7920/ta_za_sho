using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    class Class1
    {
        protected List<int> list = new List<int>();

        protected int s = 0;
        public int Size { get; }
        public Class1() { }
        protected int InputData()
        {
            int d;

            do
            {
                int t = s;
                Console.Write($"Элементы № {++t} (\"0\" or \"1\") = ");
                d = Convert.ToInt32(Console.ReadLine());
                if (d != 0 && d != 1)
                {
                    Console.WriteLine("Ошибка!");
                }
            } while (d != -833);

            s++;
            return d;
        }
        public void AddElement()
        {
            list.Add(InputData());

        }
        public void DisplayList()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}\n");
            }
        }
        public void DisplayElement(int i)
        {
            Console.Write($"{list[i]}");
        }
        public int[] ListToArray()
        {
            int[] arr = list.ToArray();
            return arr;
        }
    }
}