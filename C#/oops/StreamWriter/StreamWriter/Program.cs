using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Write write = new Write();
            Console.WriteLine(write.WriteText(System.IO.Directory.GetCurrentDirectory() + "\\Write.txt", "Hi Kishor"));
            
            Console.ReadLine();
        }
    }
}
