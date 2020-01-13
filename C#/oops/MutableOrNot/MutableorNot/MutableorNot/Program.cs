using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutableorNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 100;
            ModifyScore(score);
            Console.WriteLine(score);

            int[] scores = { 10, 20, 30, 40 };
            ModifyArray(scores);
            foreach (int item in scores)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        public static void ModifyArray(int[] scoretwo)
        {
            for (int i = 0; i < scoretwo.Length; i++)
            {
                scoretwo[i] = 0; 
            }
        }

        public static void ModifyScore(int score)
        {
            score = score + 1;
        }
    }


}

