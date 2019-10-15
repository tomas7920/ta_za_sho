using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLW5
{
    //Лаба №5, Завдання №3
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

            do
            {
                Console.Write("m: ");
                m = Int32.Parse(Console.ReadLine());

                if (m <= 0)
                Console.WriteLine("Error :c");

            } while (m <= 0);

            int[,] arr = new int[n, m];

            Console.WriteLine("Input our array:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Output:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("\t{0,1}\t", arr[i, j]);
                }
                Console.WriteLine();
            }

            int min = arr[0, 0];
            int max = arr[0, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (max > arr[i, j])
                    {
                        max = arr[i, j];

                    }

                    if (min < arr[i, j])
                    {
                        min = arr[i, j];
                    }
                }
            }

            Console.WriteLine("Минимальное значение в строках: ");

            for (int i = 0; i < n; i++)
            {
                int minLine = arr[i, 0];
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] < minLine)
                    {
                        minLine = arr[i, j];
                    }
                }
                Console.WriteLine("Строка {0}, значение: {1}", i, minLine);
                Console.WriteLine();
            }

            Console.WriteLine("Максимальное значение в строках: ");

            for (int i = 0; i < n; i++)
            {
                int maxLine = arr[i, 0];
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] > maxLine)
                    {
                        maxLine = arr[i, j];
                    }
                }
                Console.WriteLine("Строка {0}, значение: {1}", i, maxLine);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}