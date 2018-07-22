using MessageLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageLibrary;

namespace MessageConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UsersList usersList = new UsersList();
            User newUser = usersList.CreateAccount();

            PostsList postsList = new PostsList();

            int option;
            do
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Create posts");
                Console.WriteLine("2 - Display posts");
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        Post newPost = postsList.CreatePost(newUser);
                        break;
                    case 2:
                        postsList.DisplayPosts();
                        break;
                    default:
                        break;
                }
            } while (option != 0);
        }
    }
}
