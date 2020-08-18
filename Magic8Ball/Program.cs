using System;
using Magic_8_Ball;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    class Program
    {
        // Instantiate a randomObject to use later 
        public static Random randomObject = new Random();

        // Main Method invokation
        public static void Main(string[] args)
        {

            Magic8ball.programInfo();

            // Create a while loop (loops infinitely)
            while (true)
            {
                string questionString = Magic8ball.getQuestion();

                // Create an artificial pause to mimic thinking
                int numberOfSecondsToSleep = ((randomObject.Next(5) + 1) * 1000);
                Console.WriteLine("Thinking...");
                Thread.Sleep(numberOfSecondsToSleep);

                //Check if user entered a question, if not run the loop back
                if (questionString.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type a question!");
                    continue;
                }


                // Quit the loop when user types "quit"
                if (questionString.ToLower() == "quit")
                {
                    return;
                }

                Magic8ball.definedBallReplies();
            }
        }
    }
}
