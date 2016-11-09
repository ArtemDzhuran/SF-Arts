using System.Data.Entity;
using DataAccess.Models;


namespace DataAccess.DbContexts
{
    public class PostsDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}