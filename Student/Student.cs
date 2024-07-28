using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student : IStudent
    {
        private readonly string _name;
        private readonly int _age;
        private readonly int _grade;
        public Student(string Name, int Age, int Grade)
        {
            this._name = Name;
            this._age = Age;
            this._grade = Grade;
        }
        public string Name => _name;
        public int Age => _age;
        public int Grade => _grade; 

    }
}
