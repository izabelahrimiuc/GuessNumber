using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLibrary
{
    public class PostsList
    {
        public List<Post> Posts { get; private set; }
        public int PostsCount { get; set; }

        public PostsList()
        {
            Posts = new List<Post>();
            PostsCount = 1;
        }

        public Post CreatePost(User newUser)
        {
            Console.WriteLine("Enter your message:");
            string message = Console.ReadLine();

            Post post = new Post(newUser, DateTime.Now, message);
            Posts.Add(post);
            PostsCount++;

            return post;
        }

        public void DisplayPosts()
        {
            if (Posts.Count == 0)
            {
                Console.WriteLine("No posts.");
            }
            else
            {
                Console.WriteLine("All posts:");
                foreach (Post post in Posts)
                {
                    Console.WriteLine(string.Format(
                        "{0} on {1} by {2} {3}",
                        post.Message,
                        post.TimeOfPosting.ToString(),
                        post.Author.FirstName,
                        post.Author.LastName));

                }
            }
        }
    }
}
