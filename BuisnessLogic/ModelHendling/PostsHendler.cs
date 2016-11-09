using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer.DbContexts;
using DataAccesLayer.Models;
using NLog;

namespace BuisnessLogic.ModelHendling
{
    public class PostsHendler
    {

        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public PostsHendler()
        {
            _logger.Trace("Posts hednler was created");
        }

        public List<Post> GetPostsOfCategoryId(int id)
        {
            _logger.Trace("PostsHandler GetPostsOfCategoryId was called with next params: id:" + id);
            List<Post> posts;
            using (PostsDbContext db = new PostsDbContext())
            {
                posts = db.Posts.Where(post => post.Category.Id == id).ToList();
            }
            return posts;
        }

        public List<Post> GetAllPosts()
        {
            _logger.Trace("PostsHandler GetPostsAllPosts was called");
            using (PostsDbContext db = new PostsDbContext())
            {
                return db.Posts.ToList();
            }
        } 
    }
}
