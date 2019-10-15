using System;

namespace CSharp77
{
    // 7. Реалізувати метод, що буде масив повертати задом навпаки (Використання Array.Reverse() заборонено!)
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { '0', '1', '1', '2', '3', '5', '8'};

            Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

            Console.ReadLine();
        }

        static char[] Reverse(char[] arr)
        {
            char[] arrreverse = new char[arr.Length];

            int counter = 0;

            for (int i = arr.Length; i > 0; i--)
            {
                arrreverse[counter] = arr[i - 1];

                counter++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arrreverse[i];

                counter++;
            }

            return arr;
        }
    }
}