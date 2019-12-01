using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLW9
{
    class Circle:ColCon, Interface
    {
        protected double radius = 0;

        protected double area = 0;

        protected double length = 0;

        readonly double pi = 3.1415926535897932384626433832795;
        public Circle() { }
        protected Circle(string name):base(name, 0)
        {
            Random r = new Random();
            radius = r.Next(1, 100);
        }
        protected Circle(string name, double radius):base(name, 0)
        {
            this.radius = radius;
        }
        protected Circle(string name, double radius, string color):base(name, 0, color)
        {
            this.radius = radius;
        }
        static public Circle InputData()
        {
            Circle c;

            bool isRadius = false;
            bool isColor = false;
            bool isName = true;

            double radius;
            string color;
            string name;

            do
            {
                Console.Write("Enter name of Circle: ");
                name = Convert.ToString(Console.ReadLine());
                if (name == string.Empty)
                {
                    Console.WriteLine("Incorrect name!");
                }
            } while (name == string.Empty);

            radius = DoubleNumber();

            if (radius != 0)
            {
                isRadius = true;
            }
            else
            {
                Console.WriteLine("Hello, it`s random)00");
            }

            Console.Write("Enter Color of your Square: ");

            color = Convert.ToString(Console.ReadLine());

            if (color != string.Empty)
            {
                isColor = true;
            }
            else
            {
                Console.WriteLine("Hello, it`s random)00");
            }

            if (isName == true && isRadius == true)
            {
                if (isName == true && isRadius == true && isColor == true)
                {
                    c = new Circle(name, radius, color);
                    return c;
                }
                else
                {
                    c = new Circle(name, radius);
                    return c;
                }
            }
            else
            {
                c = new Circle(name);
                return c;
            }
        }
        protected void ViewData()
        {
            Console.WriteLine($"\nName: {name}\nNumber of Verticles: {vertices}\nColor: {colorrr}\n" +
                $"Radius: {radius}\nArea: {area}\nPerimetr: {length}");
        }
       
        public override void Area()
        {
            area = pi * radius * radius;
            Console.WriteLine($"Square area = {area}");
        }
        
        public override void P()
        {
            length = 2 * pi * radius;
            Console.WriteLine($"Square perimetr = {length}");
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
