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
                    ColoredConsoleWrite("Please type a question!", ConsoleColor.Red);
                    continue;
                }

                if (String.Compare(question, "quit", StringComparison.OrdinalIgnoreCase) == 0) {
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
            ColoredConsoleWrite("Magic ", ConsoleColor.Green);
            ColoredConsoleWrite("8 Ball ", ConsoleColor.Blue);
            ColoredConsoleWrite("By: ", ConsoleColor.Yellow);
            ColoredConsoleWrite("Caty Caldwell", ConsoleColor.DarkMagenta, true);
        }

        /// <summary>
        /// This function will return text the user types
        /// </summary>
        /// <returns>The question the user typed</returns>
        private static string promptUserForQuestion()
        {
            ColoredConsoleWrite("Ask a question?: ", ConsoleColor.DarkGray);
            return ColoredConsoleReadLine(ConsoleColor.Black);
        }

        /// <summary>
        /// Writes in a specific color to the console restoring default state
        /// </summary>
        public static void ColoredConsoleWrite(string text, ConsoleColor color, bool newLine = false)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = originalColor;

            if (newLine) {
              Console.WriteLine();
            }
        }

        public static string ColoredConsoleReadLine(ConsoleColor color)
        {
            String line = null;

            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            line = Console.ReadLine();
            Console.ForegroundColor = originalColor;

            return line;
        }
    }
}
