using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLW4
{
    //Лаба №4, Завдання №6
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            do
            {
                Console.Write("n: ");
                n = Int32.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("Error :c");

            } while (n <= 0);

            int[] arr = new int[n];
            int[] carr = new int[n];
            int min = 0;
            int max = 0;

            Random rnd = new Random();
            Console.WriteLine("Наш масив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-30, 30);
                carr[i] = arr[i];

                Console.Write("\t{0,1}\t", arr[i]);
                if (arr[min] > arr[i])
                    min = i;
                if (arr[max] < arr[i])
                    max = i;
            }

            int tmp = carr[min];
            carr[min] = carr[max];
            carr[max] = tmp;
            Console.WriteLine("\n");

            Console.WriteLine("Перероблений масив: ");
            for (int i = 0; i < carr.Length; i++)
            {
                arr[i] = carr[i];
                carr[i] = arr[i];

                Console.Write("\t{0,1}\t", arr[i]);
                if (arr[min] > arr[i])
                    min = i;
                if (arr[max] < arr[i])
                    max = i;
            }

            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}