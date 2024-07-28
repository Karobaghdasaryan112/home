using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    internal class Triangle : IShape
    {
        private readonly double _base;
        private readonly double _height;
        public Triangle(double @base, double height)
        {
            _base = @base;
            _height = height;
        }
        public void CalculateArea()
        {
            Console.WriteLine((_base * _height)/2);
        }
    }
}
