using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FilePathWriting
{
    internal class FileLogger : ILogger
    {
        private const string DirectoryName = @"C:\Users\User\OneDrive\Рабочий стол\Текстовый документ.txt";
        public void Log(string message)
        {

            StreamWriter Sw = new StreamWriter(DirectoryName, true);
            Sw.WriteLine(message);
            Sw.Close();
        }
    }
}
