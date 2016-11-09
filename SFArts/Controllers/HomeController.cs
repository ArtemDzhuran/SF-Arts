using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccesLayer.Models;
using BuisnessLogic.ModelHendling;
using DataAccesLayer.DbContexts;
using NLog;
using SFArts.Models;
using NLog;
using NLog.Targets;
using NLog.Config;

namespace SFArts.Controllers
{
    public class HomeController : Controller
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            try
            {
                _logger.Trace("Processing request Home/Index");


                #region Adding new posts. Coomented

                //using (PostsDbContext db = new PostsDbContext())
                //{
                //    db.Posts.Add(new Post()
                //    {
                //        ID = 2,
                //        Category = db.Categories.Find(3),
                //        ImageURL = "../../Content/Images/Events/men-in-park.jpeg",
                //        Content = "Lorem ipsum dolor sit amet," +
                //        " consectetur adipiscing elit, sed do eiusmod tempor incididunt " +
                //        " ut labore et dolore magna aliqua.Ut enim ad minim veniam," +
                //        " quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. < a href =\"#\">See more...</a>"
                //    });
                //    db.Posts.Add(new Post()
                //    {
                //        ID = 1,
                //        Category = db.Categories.Find(3),
                //        ImageURL = "../../Content/Images/Events/conductor.jpg",
                //        Content = "Lorem ipsum dolor sit amet," +
                //        " consectetur adipiscing elit, sed do eiusmod tempor incididunt " +
                //        " ut labore et dolore magna aliqua.Ut enim ad minim veniam," +
                //        " quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. < a href =\"#\">See more...</a>"
                //    });
                //    db.Posts.Add(new Post()
                //    {
                //        ID = 2,
                //        Category = db.Categories.Find(3),
                //        ImageURL = "../../Content/Images/Events/earthshake.jpg",
                //        Content = "Lorem ipsum dolor sit amet," +
                //        " consectetur adipiscing elit, sed do eiusmod tempor incididunt " +
                //        " ut labore et dolore magna aliqua.Ut enim ad minim veniam," +
                //        " quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. < a href =\"#\">See more...</a>"
                //    });

                //    db.Posts.Add(new Post()
                //    {
                //        ID = 2,
                //        Category = db.Categories.Find(3),
                //        ImageURL = "../../Content/Images/Events/manufacturer.jpg",
                //        Content = "Lorem ipsum dolor sit amet," +
                //        " consectetur adipiscing elit, sed do eiusmod tempor incididunt " +
                //        " ut labore et dolore magna aliqua.Ut enim ad minim veniam," +
                //        " quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. < a href =\"#\">See more...</a>"
                //    });

                //    db.Posts.Add(new Post()
                //    {
                //        ID = 2,
                //        Category = db.Categories.Find(3),
                //        ImageURL = "../../Content/Images/Events/lama.jpg",
                //        Content = "Lorem ipsum dolor sit amet," +
                //        " consectetur adipiscing elit, sed do eiusmod tempor incididunt " +
                //        " ut labore et dolore magna aliqua.Ut enim ad minim veniam," +
                //        " quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. < a href =\"#\">See more...</a>"
                //    });
                //    db.Posts.Add(new Post()
                //    {
                //        ID = 2,
                //        Category = db.Categories.Find(3),
                //        ImageURL = "../../Content/Images/Events/exhibition.jpeg",
                //        Content = "Lorem ipsum dolor sit amet," +
                //        " consectetur adipiscing elit, sed do eiusmod tempor incididunt " +
                //        " ut labore et dolore magna aliqua.Ut enim ad minim veniam," +
                //        " quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. < a href =\"#\">See more...</a>"
                //    });
                //    db.SaveChanges();


                //}

                #endregion

                _logger.Trace("Processing request Home/Index finished. Returning View");
                return View();
            }
            catch (Exception exception)
            {
                _logger.Error("Processing request Home/Index finished with next errors: " + exception.Message);
                return null;
            }
        }

        public JsonResult GetPostsOfCategoryId(int id)
        {
            try
            {
                _logger.Trace("Processing request Home/GetPostsOfCategoryId with next params: id=" + id);

                PostsHendler hendler = new PostsHendler();
                var posts = hendler.GetPostsOfCategoryId(id);

                _logger.Trace("Processing request Home/GetPostsOfCategoryId finished successfully. Returning Json");
                return Json(posts, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exception)
            {
                _logger.Error("Processing request Home/GetPostsOfCategoryId finished with next errors: " + exception.Message);
                return Json(new {ErrorMessage = exception.Message}, JsonRequestBehavior.AllowGet);
            }
        }

    }
}