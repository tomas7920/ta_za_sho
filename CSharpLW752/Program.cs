using System;

namespace CSharpLW752
{
    // 2. Виводить будь-яку строку в зворотному порядку(АБВ-> ВБА)
    class Program
    {
        static void Main(string[] args)
        {
            string s;

            s = Convert.ToString(Console.ReadLine());

            Reverse(ref s);

            Console.WriteLine($"{s}");
            Console.ReadLine();
        }
        static void Reverse(ref string str)
        {
            char[] arr = str.ToCharArray();

            char[] arrreverse = new char[arr.Length];

            int j = 0;

            for (int i = arr.Length; i > 0; i--)
            {
                arrreverse[j] = arr[i - 1];
                j++;
            }

            string SR = new string(arrreverse);

            str = SR;
        }
    }
}