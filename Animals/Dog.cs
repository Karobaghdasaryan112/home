using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Dog : IAnimal
    {
        void IAnimal.Eat()  
        {
            Console.WriteLine("Dog is eating");
        }
        public void Sleep()
        {
            Console.WriteLine("Dog is Sleeping");
        }
    }
}
