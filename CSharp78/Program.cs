using System;

namespace CSharp78
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = {'0','1','1','5','8','7','8','2'};

            Reverse1(ref arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

            Console.ReadLine();
        }
        static void Reverse1(ref char[] arr) //8.1
        {
            char[] arrreverse = new char[arr.Length];

            int j = 0;

            for (int i = arr.Length; i > 0; i--)
            {
                arrreverse[j] = arr[i - 1];

                j++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arrreverse[i];

                j++;
            }
        }

        //static void Reverse2(out char[] arr) //8.2 не дороблено
        //{
 
        //    char[] arrreverse = new char[arr.Length];

        //    int j = 0;

        //    for (int i = arr.Length; i > 0; i--)
        //    {
        //        arrreverse[j] = arr[i - 1];

        //        j++;
        //    }

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = arrreverse[i];

        //        j++;
        //    }
        //}
    }
}