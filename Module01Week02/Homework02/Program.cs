using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "The flower";
            string s2 = "is yellow.";

            string modifiedLetter = s1.Replace('w', 'i');
            string modifiedWord = s2.Replace("yellow","blue");
            string emptyString = string.Empty;

            var concatenateStrings = string.Concat(s1, " ", modifiedWord);
            Console.WriteLine(concatenateStrings);

            string longSentence = "Mersul pe munte este relaxant. Poti vedea peisaje frumoase. ";
            string searchWord = "munte";
            int indexOfName = longSentence.IndexOf('j');
            string upperString = longSentence.ToUpper();
            string stringTrimmed = longSentence.TrimEnd();

            if (longSentence.Contains(searchWord))
            {
                Console.WriteLine("Textul contine cuvantul 'munte'!");
            }
            else
            {
                Console.WriteLine("Cuvantul 'munte' nu a fost gasit!");
            }
            
            string nameLowerCase = "nice flower";
            string nameUpperCase = "Nice flower";

            if (string.Compare(nameLowerCase, nameUpperCase) == 0)
            {
                Console.WriteLine("Case sensitive: Caracterele sunt identice.");
            }
            else
            {
                Console.WriteLine("Case sensitive: Caracterele sunt diferite.");
            }
        }
    }
}
