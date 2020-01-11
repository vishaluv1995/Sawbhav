using System;

namespace WelcomeApp
{
    class Program
    {

        static void Main(string[] arguments)
        {
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("Hello" + " " + args[i].ToString());
            //}
            foreach (string item in arguments)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
