using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLW6
{
    //Лаба №6, Завдання №11
    class Program
    {
        static void Main()
        {
            string exp = null;
            char[] n = new char[] { };
            byte b;

            Console.Write("Введите число: ");
            do
            {
                exp = Console.ReadLine();

                if (exp.All(char.IsDigit))
                {
                    n = exp.ToCharArray();
                    exp = null;
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }

            } while (exp != null);

            List<byte> num = new List<byte>();

            foreach (char i in n)
            {
                num.Add(Convert.ToByte(i));
            }

            Console.Write("Вы ввели: ");
            for (int i = 0; i < num.Count; i++)
            {
                num[i] -= 48; // перевод из utf-8 в цифру
                Console.Write(num[i]);
            }

            num.Sort();

            Console.WriteLine();
            byte old = 0;
            byte same = 0;
            foreach (byte i in num)
            {
                if (old != i)
                {
                    if (same > 1)
                        Console.WriteLine("Количество {0}: {1}", old, same);
                    same = 0;
                }
                same++;
                old = i;
            }

            Console.Write("Введите цифру которую надо найти: ");
            do
            {
                exp = Console.ReadLine();

                if (byte.TryParse(exp, out b))
                {
                    exp = null;
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }

            } while (exp != null);

            bool innum = false;
            foreach (byte i in num)
            {
                if (b == i)
                {
                    Console.WriteLine("Да, эта цифра входит в это число.");
                    innum = true;
                    break;
                }
            }

            if (innum == false)
            {
                Console.WriteLine("Нет, эта цифра не входит в это число.");
            }

            Console.ReadKey();
        }
    }
}