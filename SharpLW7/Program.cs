using System;

namespace SharpLW751
{
    // 1. Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("n: ");
            n = Int32.Parse(Console.ReadLine());

            Reverse(ref n);

            Console.WriteLine("Now n: {0}", n);
            Console.ReadLine();
        }
        static void Reverse(ref int n)
        {
            int temp, a = 0;

            while (n != 0)
            {
                temp = n % 10;
                a = a * 10 + temp;
                n = n / 10;
            }

            n = a;
        }
    }
}