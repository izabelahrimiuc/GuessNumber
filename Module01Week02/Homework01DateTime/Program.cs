using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01DateTime
{
    public enum Gender
    {
        Female,
        Male
    }
    class Program
    {
        private const int retirementAgeMale = 65;
        private const int retirementAgeFemale = 63;

        private static Gender? getGender(String gender)
        {
            if (gender.Equals("m"))
            {
                return Gender.Male;
            }
            else if (gender.Equals("f"))
            { 
                return Gender.Female;
            }
            else return null;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter birthdate and gender (m/f):");

            Console.WriteLine("Year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Day:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Gender:");
            Gender? gender = getGender(Console.ReadLine().ToLower());


            DateTime birthDate = new DateTime(year,month,day);
            DateTime now = DateTime.Now;

            TimeSpan personLifeTime = now - birthDate;

            int age = (int)(personLifeTime.Days / 365.242216);
            Console.WriteLine($"The person age is {age}");
            
            if(gender.HasValue)
            {
                if (gender.Value == Gender.Female)
                {
        
                    if (age >= retirementAgeFemale)
                    {
                        Console.WriteLine("The person is retired!");
                    }
                    else
                    {
                        Console.WriteLine("The woman will be retired at 63, in " + (63 - age) + " years.");
                    }
                }
                else
                {
                    if (age >= retirementAgeMale)
                    {
                        Console.WriteLine("The person is retired!");
                    }
                    else
                    {
                        Console.WriteLine("The man will be retired at 65, in " + (65 - age) + " years.");
                    }
                }
            } 
            else
            {
                Console.WriteLine("Please enter a valid gender:");
            }     
        }
    }
}
