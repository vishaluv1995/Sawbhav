using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput;
            int randomNum;
            int countattempt;

            string UserAnwers = string.Empty;

            bool IsCorrectAns = false;

            Console.WriteLine("Can We start game ??");
            Console.WriteLine("Press '1': For start or Press '2': For Exists");

            UserAnwers = Console.ReadLine();
            userinput = Convert.ToInt32(UserAnwers);

            if (userinput == 2)
            {
                return;
            }

        lblGameRestart:
            randomNum = RandomNumber(1, 100);
            Console.WriteLine("Random Number Generated :"+randomNum);
            Console.WriteLine("Guess Number from 1 to 100 if your number match with which we have then you will win");
            countattempt = 1;

        lblInCorrectAnswer:
            while (IsCorrectAns != true)
            {
                UserAnwers = Console.ReadLine();
                userinput = Convert.ToInt32(UserAnwers);

                if (userinput == randomNum)
                {
                    Console.WriteLine("You attempted to guess Number :" + countattempt);
                    Console.WriteLine("You wins game,Do you want to play again ?");
                    Console.WriteLine("Press '1': For Continue or Press '2': For Exists");

                    UserAnwers = Console.ReadLine();
                    userinput = Convert.ToInt32(UserAnwers);

                    if (userinput == 2)
                    {
                        return;
                    }

                    countattempt = 0;
                    goto lblGameRestart;
                }
                else if (userinput < randomNum)
                {
                    Console.WriteLine("Sorry,Too Low");
                    Console.WriteLine("Try Again");
                    countattempt++;
                    goto lblInCorrectAnswer;
                }
                else if (userinput > randomNum)
                {
                    Console.WriteLine("Sorry,Too High");
                    Console.WriteLine("Try Again");
                    countattempt++;
                    goto lblInCorrectAnswer;
                }
            }
            Console.Read();
        }

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
