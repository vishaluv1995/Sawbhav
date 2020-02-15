using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Read read = new Read();
            string filepath = System.IO.Directory.GetCurrentDirectory() + "\\Read.txt";
            Console.WriteLine(read.ReadFile(filepath));
            Console.Read();
        }
    }
}
