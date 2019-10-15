using System;

namespace CSharpLW754
{
    // 4. Виводити будь-яку строку в зворотному порядку і всі елементи після “магічного знаку” теж в зворотному(АБВ, ГДЕ->ВБА, ЕДГ)
    class Program
    {
        static void Main(string[] args)
        {
            string s = Convert.ToString(Console.ReadLine());

            Reverse(ref s);

            Console.WriteLine(s);
        }
        static void Reverse(ref string s)
        {
            char[] arr = s.ToCharArray();

            char[] arrreverse = new char[arr.Length];

            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ',')
                {
                    counter = i + 1;
                }
            }

            char[] one = new char[counter];

            char[] two = new char[(arr.Length) - counter];

            int counter1 = 0;

            for (int i = counter - 2; i >= 0; i--)
            {
                one[counter1] = arr[i];

                counter1++;
            }

            one[counter - 1] = ',';

            int counter2 = 0;

            for (int i = arr.Length - 1; i > counter - 1; i--)
            {
                two[counter2] = arr[i];
                counter2++;
            }

            for (int i = 0; i < counter; i++)
            {
                arrreverse[i] = one[i];
            }

            int counter3 = 0;

            for (int i = counter; i < arr.Length; i++)
            {
                arrreverse[i] = two[counter3];
                counter3++;
            }

            s = new string(arrreverse);

            Console.ReadLine();
        }
    }
}