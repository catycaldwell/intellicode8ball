using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8ball
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program.printInfo();

            Random randomGenerator = new Random();
            Magic8ball magic8ball = new Magic8ball(randomGenerator);

            while (true)
            {
                string question = Program.promptUserForQuestion();
                if (String.IsNullOrEmpty(question)) {
                    //Loop back if the user didn't type a question
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type a question!");
                    continue;
                }

                // Quit the loop when user types "quit"
                if (question.ToLower() == "quit")
                {
                    return;
                }

                // Create an artificial pause to mimic thinking
                int numberOfSecondsToSleep = ((randomGenerator.Next(5) + 1) * 1000);
                Console.WriteLine("Thinking...");
                Thread.Sleep(numberOfSecondsToSleep);
                Console.WriteLine(magic8ball.getRandomReply());
            }
        }

        /// <summary>
        /// This will print the name of the program and the creator of it
        /// </summary>
        private static void printInfo()
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Magic ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("8 Ball");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("By: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Caty Caldwell ");
            Console.WriteLine();
            Console.ForegroundColor = originalColor;
        }

        /// <summary>
        /// This function will return text the user types
        /// </summary>
        /// <returns></returns>
        private static string promptUserForQuestion()
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Ask a question?: ");
            Console.ForegroundColor = ConsoleColor.Black;
            String questionString = Console.ReadLine();
            Console.ForegroundColor = originalColor;
            return questionString;
        }
    }
}
