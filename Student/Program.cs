using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("karo", 21, 3);
            Console.WriteLine(
                $"Name is --- {student.Name}\n" +
                $"Age is --- {student.Age}\n" +
                $"Grade is --- {student.Grade} \n"
                );
            Console.ReadLine();
        }
    }
}
