using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLW9
{
    class Square:ColCon, Interface
    {
        protected double sLendth = 0;
        protected double sArea = 0;
        protected double sP = 0;

        public Square() { }
        protected Square(string name):base(name, 4)
        {
            Random r = new Random();
            sLendth = r.Next(1, 100);
        }
        protected Square(string name, double sLendth):base(name, 4)
        {
            this.sLendth = sLendth;
        }
        protected Square(string name, double sLendth, string color):base(name, 4, color)
        {
            this.sLendth = sLendth;
        }
        static public Square InputData()
        {
            Square s;

            bool isName = true;
            bool isSideLendth = false;
            bool isColor = false;

            string name;
            double lendth;
            string color;

            do
            {
                Console.Write("Name of Square: ");
                name = Convert.ToString(Console.ReadLine());
                if (name == string.Empty)
                {
                    Console.WriteLine("Incorrect name!");
                }
            } while (name == string.Empty);

            lendth = DoubleNumber();

            if (lendth != 0)
            {
                isSideLendth = true;
            }
            else
            {
                Console.WriteLine("Hello, it`s random)00");
            }

            Console.Write("Color of your Square: ");

            color = Convert.ToString(Console.ReadLine());

            if (color != string.Empty)
            {
                isColor = true;
            }
            else
            {
                Console.WriteLine("Hello, it`s random)00");
            }

            if (isName == true && isSideLendth == true)
            {
                if (isName == true && isSideLendth == true && isColor == true)
                {
                    s = new Square(name, lendth, color);
                    return s;
                }
                else
                {
                    s = new Square(name, lendth);
                    return s;
                }
            }
            else
            {
                s = new Square(name);
                return s;
            }
        }
        protected void ViewData()
        {
            Console.WriteLine($"\nName: {name}\nNumber of Verticles: {vertices}\nColor: {colorrr}\n" +
                $"Side Lendth: {sLendth}\nArea: {sArea}\nPerimetr: {sP}");
        }
        public override void Area()
        {
            sArea = sLendth * sLendth;
            Console.WriteLine($"Square Area = {sArea}");
        }
        public override void P()
        {
            sP = 4 * sLendth;
            Console.WriteLine($"Square P = {sP}");
        }
        public void Draw()
        {
            string colorOfLetters = colorrr;
            ChangeColorOfLetters(colorOfLetters);
            ViewData();
            Console.ResetColor();
        }
    }
}
