using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Circle(10),
                new Rectangle(10, 10.8),
                new Triangle(15, 48),
            };
            foreach (var shape in shapes)
            {
                shape.CalculateArea();
            }
            Console.ReadLine();
        }
    }
}
