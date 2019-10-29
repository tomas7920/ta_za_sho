using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLW8
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGarage Garage = new MyGarage();

            for (int i = 0; i < 1; i++)
            {
                Garage.SetCar();
            }

            Garage.OverviewCars();

            Garage.GetCar();

            Garage.DeleteCar();

            Console.ReadLine();
        }
    }
}