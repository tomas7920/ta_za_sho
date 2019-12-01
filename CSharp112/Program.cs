using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp112
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = null;

            students.Add(new Student("Ацерон", "Олег", 33));

            students.Add(new Student("Бардак", "Олександр", 18));

            students.Add(new Student("Гройсмен", "Артем", 15));

            students.Add(new Student("Дуконов", "Ярослав", 50));

            students.Add(new Student("Єрохін", "Микита", 56));

            students.Add(new Student("Заразкін", "Миколай", 70));

            students.Add(new Student("Іпашков", "Павло", 27));

            students.Add(new Student("Куренів", "Данило", 30));

            students.Add(new Student("Ломак", "Георгій", 47));

            students.Add(new Student("Мороз", "Дмитро", 40));

            Extension.FindStudent(students, Student.AgeMore18());

            Extension.FindStudent(students, Student.IsFirstLetterA());

            Extension.FindStudent(students, Student.IsLastNameMoreThanThreeSymbols());

            Console.ReadKey();
        }
    }
}