using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp112
{
    class Extention
    {
        public static List<Student> FindStudent(Student student, StudentPredicateDelegate studentPredicateDelegate)
        {
            List<Student> students = new List<Student>();
            bool temp = studentPredicateDelegate(student);
            if (temp)
            {
                students.Add(student);
            }
            

            return students;
        }
    }
}
