/*** 
 * <Summary > 
 * 
 * This console app replicates a Magic 8 Ball. A Magic 8 ball,
 *  <https://en.wikipedia.org/wiki/Magic_8-Ball>, is a game where the user asks
 *  a Yes-No question and shakes a 8-ball object to reveal an answer. 
 *  
 *  Run this app, ask a Yes/No question, and type 'quit' to exit.
 *
 * **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8ball
{
    /// <summary>
    /// Class to manage our magic 8 ball.
    /// </summary>
    class Magic8ball
    {
        private readonly Random _randomGenerator;
        private readonly string[] _replies = { 
            "YES!", 
            "NO!",
            "It is certain!",
            "It is decidedly so!",
            "Without a doubt!",
            "You may rely on it!",
            "Not in the cards.",
            "Most likely!",
            "Outlook is good!",
            "Reply hazy. Try again.",
            "Ask again later.",
            "Better not tell you now.",
            "Unlikely.",
            "Cannot predict now.",
            "Concentrate and ask again.",
            "Don't count on it.",
            "My sources say no.",
            "Outlook not so good.",
            "Very doubtful."
        };
        
        // <summary>
        // Constructor for Magic8Ball
        // </summary>
        public Magic8ball(Random randomGenerator = new Random()) {
            _randomGenerator = random;
        }            
            
        /// <summary>
        /// This gives a random generated pre-defined 8 ball reply
        /// </summary>
        public static string getRandomReply()
        {
            return _replies[randomObject.Next(_replies.Length)];
        }        
    }
}
