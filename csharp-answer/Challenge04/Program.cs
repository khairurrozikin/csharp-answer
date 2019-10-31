using System;
using System.Collections;

namespace Substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have some word collection ...
            var censoredWords = new ArrayList();
            censoredWords.Add("imperdiet");
            censoredWords.Add("dolor");
            censoredWords.Add("duo");

            // and a paragraph.
            // var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";
            
            Console.WriteLine(censoredWords[0]);
            Console.WriteLine(censoredWords[1]);
            Console.WriteLine(censoredWords[2]);
            
            censoredWords[0] = "*****";
            censoredWords[1] = "********";
            censoredWords[2] = "********";
            
            var paragraph = $"Lorem ipsum {censoredWords[0]} sit amet, {censoredWords[1]} vituperata {censoredWords[2]} in, nonumy.";
            
            Console.WriteLine(paragraph);
            // Censor the words in paragraph by using * symbol.
            // Output example:
            // Lorem ipsum ***** sit amet, ********* vituperata *** in, nonumy.
        }
    }
}
