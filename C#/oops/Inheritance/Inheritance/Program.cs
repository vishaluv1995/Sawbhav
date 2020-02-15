using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeC employeec = new EmployeeC();
            Console.WriteLine("Add:" + employeec.Add(1, 1));
            Console.WriteLine("Subtract:" + employeec.subtract(1, 1));
            Console.WriteLine("Multiply:" + employeec.Multiply(1, 1));
            Console.WriteLine("Divide:" + employeec.Divide(1, 1));
            Console.Read();
        }
    }
}
