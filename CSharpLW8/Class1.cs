using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLW8
{
    class Character
    {
        protected string Name;

        protected string Color;

        protected double Speed;

        protected int Year;
        public string NameOfCar { get { return Name; } }
        public string ColorOfCar { get { return Color; } }
        public double SpeedOfCar { get { return Speed; } }
        public int YearOfCar { get { return Year; } }
        public Character(string Name, string Color, double Speed, int Year)
        {
            this.Name = Name;

            this.Color = Color;

            this.Speed = Speed;

            this.Year = Year;
        }
    }
}