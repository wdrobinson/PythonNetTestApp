using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;

namespace PythonNetTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting python");
            //PythonEngine.PythonHome = "C:/FakeDir";
            PythonEngine.Initialize();
            Console.WriteLine("Python started");
            Console.ReadLine();
        }
    }
}
