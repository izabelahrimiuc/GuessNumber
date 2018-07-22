using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLibrary
{
    public enum Gender
    {
        Male,
        Female
    }

    public class UsersList
    {
        public List<User> Users { get; private set; }
        public int UserCount { get; set; }

        public UsersList()
        {
            Users = new List<User>();
            UserCount = 1;
        }

        private static Gender? GetGender(string gender)
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

        public User CreateAccount()
        {
            Console.WriteLine("Enter your informations:");

            Console.WriteLine("Firstname:");
            string firstName = Console.ReadLine().Trim();

            Console.WriteLine("Lastname:");
            string lastName = Console.ReadLine().Trim();

            Console.WriteLine("Gender:");
            Gender? gender = GetGender(Console.ReadLine().ToLower().Trim());

            Console.WriteLine("Birthdate: Year, Month, Day:");

            int year = ReadYear();
            int month = ReadMonth();
            int day = ReadDay();

            //Contains(@)
            Console.WriteLine("Email:");
            string email = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Password:");
            string password = Console.ReadLine().Trim();



            User user = new User(UserCount,"Iza", "Hrm", new DateTime(2000, 1, 1), Gender.Female, ""," ");
            Users.Add(user);
            UserCount++;

            return user;
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
            while (correctDay < 1 || correctDay > 31)
            {
                Console.WriteLine("Please enter a valid day:");
                int.TryParse(Console.ReadLine(), out correctDay);
            }

            return correctDay;
        }
    }
}
