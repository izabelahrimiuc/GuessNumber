using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserAuthentication.Models;

namespace UserAuthentication.Controllers
{
    public class PostsController : Controller
    {
        public static List<Post> posts = new List<Post>();
            public static int Id = 0;

        // GET: Posts
        public ActionResult Index()
        {
            return View(posts);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Post post = posts.Find(p => p.Id == id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            Id++;
            posts.Id = Id;
            posts.Add(post);
            return RedirectToAction("Index");
        }
    }
}