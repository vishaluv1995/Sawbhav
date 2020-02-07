using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            int sum = 0;
            int avg = 0;
            int cnt = 0;
            int tmp = 0;

            marks[0] = 10;
            marks[1] = 20;
            marks[2] = 40;
            marks[3] = 50;
            marks[4] = 70;

            Console.WriteLine("Array Application");

            foreach (int m in marks)
            {
                Console.WriteLine(m);
                Console.WriteLine("");
                sum = sum + m;
                cnt = cnt + 1;

                if (m > tmp)
                {
                    tmp = m;
                }
            }

            avg = sum / cnt;

            Console.WriteLine("Sum - " + sum);
            Console.WriteLine("Avg - " + avg);
            Console.WriteLine("Max - " + tmp);

            Console.ReadLine();
        }
    }
}
