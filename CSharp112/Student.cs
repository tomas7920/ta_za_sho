using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp112
{
   public delegate bool StudentPredicateDelegate(Student student);
    public class Student
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Age { get; set; }
        public Student() { }
        public Student(string LastName, string FirstName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
        public static bool AgeMore18(Student student)
        {
            if (student.Age >= 18) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsFirstLetterA(Student student)
        {
            if (student.FirstName[0]=='A')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsLastNameMoreThanThreeSymbols(Student student)
        {
            if (student.LastName.Length>3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}