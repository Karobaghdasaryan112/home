using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePathWriting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"C:\Users\User\OneDrive\Рабочий стол\Текстовый документ.txt"
            string message = Console.ReadLine();
            ILogger logger = new FileLogger();
           
            logger.Log(message);

            ILogger logger2 = new ConsoleLogger();
            logger2.Log(message);
            Console.ReadLine();
        }
    }
}
