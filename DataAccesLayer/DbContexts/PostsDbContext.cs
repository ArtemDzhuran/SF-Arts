using System.Data.Entity;
using DataAccesLayer.Models;

namespace DataAccesLayer.DbContexts
{
    public class PostsDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}