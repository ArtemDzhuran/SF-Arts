using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SFArts.Models;

namespace SFArts.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetPostsOfId(int id)
        {
            List<Post> posts;
            using (PostsDbContext db = new PostsDbContext())
            {
                posts = db.Posts.AsNoTracking().Where(post => post.ID == id).ToList();
            }
            return Json(posts, JsonRequestBehavior.AllowGet);
        }
    }
}