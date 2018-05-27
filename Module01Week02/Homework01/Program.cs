using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    public enum Gender
    {
        Female,
        Male
    }
    public struct BirthDate
    {
        public int year;
        public int month;
        public int day;
        //public DateTime BirthDate;
        //public Gender Gender;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthdate: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());


            BirthDate birthDate = new BirthDate();
            birthDate.Year;
            birthDate.Month;
            birthDate.Day;
            Console.WriteLine($"My age is {birthDate.Year}and {birthDate.Month} months.");

            DateTime now = DateTime.Now;
            DateTime birthDate = new DateTime(1993, 06, 12);

            DateTime birthDate = Convert.ToDateTime("8 iunie 1990");

            Console.WriteLine("Enter your gender: ");
            Gender gender = Gender.Female;
            Gender? gender = null;
            int genderAsint = (int)gender;


            if(gender.HasValue)
            {
              x=gender.Value
                     if (gender = Gender.female)
                {

                }
            }
           
        }
    }
}
