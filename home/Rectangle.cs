using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    internal class Rectangle : IShape
    {
        private readonly double _x;
        private readonly double _y;
        public Rectangle(double x,double y)
        {
            _x = x;
            _y = y;
        }
        public void CalculateArea()
        {
            Console.WriteLine(_x * _y);
        }
    }
}
