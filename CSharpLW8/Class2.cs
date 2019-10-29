using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLW8
{
    partial class MyGarage
    {
        List<Character> Cars = new List<Character>();
        protected Character EnterData()
        {
            string name, color;

            double speed;

            int year;

            do
            {
                Console.Write("Name of car: ");

                name = Convert.ToString(Console.ReadLine());

                if (name == "")
                {
                    Console.WriteLine("Error, sorry :c");
                }

            } while (name == "");

            do
            {
                Console.Write("Color of car: ");

                color = Convert.ToString(Console.ReadLine());

                if (color == "")
                {
                    Console.WriteLine("Error, sorry :c");
                }

            } while (color == "");

            do
            {
                Console.Write("Speed of car: ");

                speed = Convert.ToDouble(Console.ReadLine());

                if (speed < -138.4 || speed > 1227.986)
                {
                    Console.WriteLine("Error, sorry :c");
                }

            } while (speed < -138.4 || speed > 1227.986);

            do
            {
                Console.Write("Enter year of creation of car: ");

                year = Convert.ToInt32(Console.ReadLine());

                if (year < 1884 || year > DateTime.Today.Year)
                {
                    Console.WriteLine("Incorrect year of creation. Try again");
                }

            } while (year < 1884 || year > DateTime.Today.Year);

            return new Character(name, color, speed, year);
        }
        public void SetCar()
        {
            Cars.Add(EnterData());
        }
        public void OverviewCars()
        {
            Console.WriteLine("All cars in stock:");

            Console.WriteLine("Number: Name: Color: Speed: Year:\n");

            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {Cars[i].NameOfCar} - {Cars[i].ColorOfCar} - {Cars[i].SpeedOfCar} - {Cars[i].YearOfCar}");
            }
        }
        public void DeleteCar()
        {
            OverviewCars();

            int j;

            do
            {
                Console.Write("Delete your car on number:");

                j = Convert.ToInt32(Console.ReadLine());

                if (j < 1 || j > Cars.Count + 1)
                {
                    Console.WriteLine("Error, sorry :c");
                }
                else
                {
                    Console.WriteLine("Oh yeah, you did this!");
                }

            } while (j < 1 || j > Cars.Count + 1);

            Cars.RemoveAt(j - 1);
        }
        public void GetCar()
        {
            OverviewCars();
            int a;
            do
            {
                Console.Write("Take your car on number:");

                a = Convert.ToInt32(Console.ReadLine());

                if (a - 1 < 0 || a - 1 > Cars.Count)
                {
                    Console.WriteLine("Error, sorry :c");
                }
                else
                {
                    Console.WriteLine("Oh yeah, you did this!");
                }

            } while (a - 1 < 0 || a - 1 > Cars.Count);
        }
    }
}