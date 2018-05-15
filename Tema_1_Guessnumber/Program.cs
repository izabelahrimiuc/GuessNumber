using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1_Guessnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int randomValue = rng.Next(1, 100);
            int guess = 0;

            do
            {
                Console.WriteLine("Please enter a number");
                string str = Console.ReadLine();
                guess = int.Parse(str);

                if (guess > randomValue)
                {
                    Console.WriteLine($"The number {guess} is greater than the target number");
                }
                else if (guess < randomValue)
                {
                    Console.WriteLine($"The number {guess} is smaller than the target number");
                }
            } while (guess != randomValue);

            Console.WriteLine("You guessed the number!");
        }
    }
}
