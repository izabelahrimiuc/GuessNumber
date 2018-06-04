using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLibrary
{
    public class User
    {
        public string FirstName { get; private set; };
        public string LastName { get; private set; };
        public DateTime BirthDate { get; private set; };
        public string Email { get; private set; };

        public User(string firstName,string lastName, DateTime birthDate, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Email = email;
        }
    }

    public class Author : User
    {
        public int Post;

        public Author(int post, string firstName, string lastName, DateTime birthDate, string email)
            : base(firstName, lastName, birthDate, email)
        {
            this.Post = post;
        }
    }

    public class Post
    {
        public User Author { get; private set; };
        public DateTime TimeOfPosting { get; private set; };
        public string Message { get; private set; };

        public Post(User author, DateTime timeofPosting, string message)
        {
            this.Author = author;
            this.TimeOfPosting = timeofPosting;
            this.Message = message;
        }
    }

    public class Board
    {
        List<User> userList = new List<User>();
        List<Post> postList = new List<Post>();


    }
}
