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
            int RandomValue = rng.Next(1, 100);
            Console.WriteLine(RandomValue);
            int nr = 0;

            do
            {
                Console.WriteLine("Please enter a number");
                string str = Console.ReadLine();
                nr = int.Parse(str);

                if (nr > RandomValue)
                {
                    Console.WriteLine("The number is greater than the target number");
                }
                else if (nr < RandomValue)
                {
                    Console.WriteLine("The number is not greater than the target number");
                }
            } while (nr != RandomValue);

            Console.WriteLine("You guessed the number!");
        }
    }
}
