using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01DateTime
{
    public enum Gender
    {
        Male,
        Female
    }
    class Program
    {
        private const int retirementAgeMale = 65;
        private const int retirementAgeFemale = 63;

        private static Gender? GetGender(String gender)
        {
            switch (gender)
            {
                case "m":
                    return Gender.Male;
                case "f":
                    return Gender.Female;
                default:
                    return null;
            }
        }

        private static int ReadYear()
        {
            Console.WriteLine("Year:");
            int.TryParse(Console.ReadLine(), out int correctYear);
            while (correctYear < 1900 || correctYear > 2018)
            {
                Console.WriteLine("Please enter a valid year:");
                int.TryParse(Console.ReadLine(), out correctYear);
            }

            return correctYear;
        }


        //Correct with DateTime
        private static int ReadMonth()
        {
            Console.WriteLine("Month:");
            int.TryParse(Console.ReadLine(), out int correctMonth);
            while (correctMonth < 1 || correctMonth > 12)
            {
                Console.WriteLine("Please enter a valid month:");
                int.TryParse(Console.ReadLine(), out correctMonth);
            }

            return correctMonth;
        }

        private static int ReadDay()
        {
            Console.WriteLine("Day:");
            int.TryParse(Console.ReadLine(), out int correctDay);

            //I must generate days of a month
            //int daysInMonth = DateTime.DaysInMonth(2018,8);
            //Console.WriteLine(daysInMonth);
            while (correctDay < 1 || correctDay > 31)
            {
                Console.WriteLine("Please enter a valid day:");
                int.TryParse(Console.ReadLine(), out correctDay);
            }

            return correctDay;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter birthdate and gender (m/f):");

            int year = ReadYear();

            int month = ReadMonth();

            int day= ReadDay();

            Console.WriteLine("Gender:");
            Gender? gender = GetGender(Console.ReadLine().ToLower().Trim());


            DateTime birthDate = new DateTime(year, month, day);
            DateTime now = DateTime.Now;

            TimeSpan personLifeTime = now - birthDate;

            int age = (int)(personLifeTime.Days / 365.242216);
            Console.WriteLine($"The person's age is {age}");
            
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
