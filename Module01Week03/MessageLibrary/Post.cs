using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLibrary
{
    public class Post
    {
        public User Author { get; private set; }
        public DateTime TimeOfPosting { get; private set; }
        public string Message { get; private set; }
    
        public Post(User author, DateTime timeOfPosting, string message)
        {
            this.Author = author;
            this.TimeOfPosting = timeOfPosting;
            this.Message = message;
        }
    }
}
