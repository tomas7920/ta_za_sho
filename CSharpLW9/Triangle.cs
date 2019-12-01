using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLW9
{
    class Triangle : ColCon, Interface
    {
        protected double sideLendth = 0;
        protected double triangleArea = 0;
        protected double trianglePerimetr = 0;

        public Triangle() { }
        protected Triangle(string name) : base(name, 3)
        {
            Random r = new Random();
            sideLendth = r.Next(1, 100);
        }
        protected Triangle(string name, double sLendth) : base(name, 3)
        {
            this.sideLendth = sLendth;
        }
        protected Triangle(string name, double sLendth, string color) : base(name, 3, color)
        {
            this.sideLendth = sLendth;
        }

        static public Triangle InputData()
        {
            Triangle t;

            bool isName = true;
            bool isSideLendth = false;
            bool isColor = false;

            string name;
            double lendth;
            string color;
            do
            {
                Console.Write("Name of Triangle: ");
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

            Console.Write("Color of your Trianle: ");

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
                    t = new Triangle(name, lendth, color);
                    return t;
                }
                else
                {
                    t = new Triangle(name, lendth);
                    return t;
                }
            }
            else
            {
                t = new Triangle(name);
                return t;
            }
        }
        protected void DisplayData()
        {
            Console.WriteLine($"\nName: {name}\nNumber of Verticles: {vertices}\nColor: {colorrr}\n" +
                $"Side Lendth: {sideLendth}\nArea: {triangleArea}\nPerimetr: {trianglePerimetr}");
        }
        public override void Area()
        {
            double halfPerimetr = sideLendth * 3 / 2;
            triangleArea = Math.Sqrt(halfPerimetr * (halfPerimetr - sideLendth) * (halfPerimetr - sideLendth) * (halfPerimetr - sideLendth));
            Console.WriteLine($"Square area = {triangleArea}");
        }
        public override void P()
        {
            trianglePerimetr = sideLendth * 3;
            Console.WriteLine($"Square perimetr = {trianglePerimetr}");
        }
        public void Draw()
        {
            string colorOfLetters = colorrr;
            ChangeColorOfLetters(colorOfLetters);
            DisplayData();
            Console.ResetColor();
        }
    }
}
