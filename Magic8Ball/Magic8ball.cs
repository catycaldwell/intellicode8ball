/*** 
 * <Summary > 
 * 
 * The Magic 8-ball program contains a Program class with 
 * 
 *
 * **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic_8_Ball
{

    /// <summary>
    /// Create class Program as a main entry point for Magic 8 Ball program 
    /// </summary>

    class Magic8ball
    {
        // Instantiate a randomObject to use later 
        public static Random randomObject = new Random();

        // Preserve current console text color
        public static ConsoleColor oldColor = Console.ForegroundColor;


        /// <summary>
        /// This gives the random generated pre defined 8 ball replies
        /// out of 18 given replies
        /// </summary>
        public static void definedBallReplies()
        {
            // Create a random # (0-19)
            // because 19 replies
            int randomNumber = randomObject.Next(19);

            // Use random number to determine response
            switch (randomNumber)
            {
                case 0:
                    {
                        Console.WriteLine("YES!");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("NO!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("It is certain!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("It is decidedly so!");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Without a doubt!");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("You may rely on it!");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Not in the cards.");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Most likely!");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Outlook is good!");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Reply hazy. Try again.");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Ask again later.");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Better not tell you now.");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Unlikely.");
                        break;
                    }
                case 13:
                    {
                        Console.WriteLine("Cannot predict now.");
                        break;
                    }
                case 14:
                    {
                        Console.WriteLine("Concentrate and ask again.");
                        break;
                    }
                case 15:
                    {
                        Console.WriteLine("Don't count on it.");
                        break;
                    }
                case 16:
                    {
                        Console.WriteLine("My sources say no.");
                        break;
                    }
                case 17:
                    {
                        Console.WriteLine("Outlook not so good.");
                        break;
                    }
                case 18:
                    {
                        Console.WriteLine("Very doubtful.");
                        break;
                    }
            }
        }


        /// <summary>
        /// This will print the name of the program and the creator of it 
        /// </summary>
        public static void programInfo()
        {
            // Change Console text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Magic ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("8 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Ball ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("By: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Caty Caldwell ");
            Console.WriteLine();
        }


        /// <summary>
        /// This function will return text the user types
        /// </summary>
        /// <returns></returns>
        public static string getQuestion()
        {
            // This block of code will ask user for a question
            // and store the question text in questionString variable
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Ask a question?: ");
            Console.ForegroundColor = ConsoleColor.Black;
            String questionString = Console.ReadLine();

            return questionString;
        }
        
    }
}