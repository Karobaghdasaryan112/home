using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    internal class Circle : IShape
    {
        private readonly double _radius;
        private const double PI = 3.14;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public void CalculateArea()
        {
            Console.WriteLine(PI * _radius * _radius);
        }
    }
}
