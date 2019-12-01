using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLW9
{
    abstract class ColCon
    {
        protected string colorrr { get; set; }
        protected int vertices { get; }
        protected string name { get; }

        string[] colors = {"Black", "Blue", "Cyan", "DarkBlue", "DarkCyan", "DarkGray", "DarkGreen", "DarkMagenta", "DarkRed",
            "DarkYellow","Gray","Green","Magenta","Red","White","Yellow"};

        protected ColCon() { }
        protected ColCon(string colorrr, int vertices)
        {
            this.name = colorrr;
            this.vertices = vertices;
            Random rm = new Random();
            this.colorrr = colors[rm.Next(0, colors.Length)];
        }
        protected ColCon(string name, int vertices, string colorrr)
        {
            this.name = name;
            this.vertices = vertices;
            this.colorrr = colorrr;
        }
        abstract public void Area();
        abstract public void P();
        protected static double DoubleNumber()
        {
            double n = 0;
            Console.Write("Lendth: ");

            string row = Convert.ToString(Console.ReadLine());

            if (row != string.Empty)
            {
                bool isAllNumbers = true;
                char[] charArray = row.ToCharArray();
                for (int i = 0; i < charArray.Length; i++)
                {
                    if (!char.IsDigit(charArray[i]))
                    {
                        if (charArray[i] != '.')
                        {
                            if (charArray[i] != ',')
                            {
                                isAllNumbers = false;
                                break;
                            }
                        }
                    }
                    if (charArray[i] == '.')
                    {
                        charArray[i] = ',';
                    }
                }
                if (isAllNumbers == true)
                {
                    string str2 = new string(charArray);
                    n = Convert.ToDouble(str2);
                }
                if (n < 0)
                {
                    n = 0;
                }
            }
            return n;
        }
        protected void ChangeColorOfLetters(string s)
        {
            switch (s)
            {
                case "Black":
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    }
                case "Blue":
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }
                case "Cyan":
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    }
                case "DarkBlue":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    }
                case "DarkCyan":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    }
                case "DarkGray":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    }
                case "DarkGreen":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    }
                case "DarkMagenta":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    }
                case "DarkRed":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    }
                case "DarkYellow":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    }
                case "Gray":
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    }
                case "Green":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                case "Magenta":
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    }
                case "Red":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
                case "White":
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case "Yellow":
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Упс, такого цвета нет. Значит будет белый)");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
            }
        }
    }
}
