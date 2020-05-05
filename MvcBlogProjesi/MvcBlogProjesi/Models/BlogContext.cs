using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBlogProjesi.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("blogDb")
        {
            Database.SetInitializer(new BlogInitializer());
        }
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
        public DbSet<Comment> Yorumlar { get; set; }

        public System.Data.Entity.DbSet<MvcBlogProjesi.Models.CategoryModel> CategoryModels { get; set; }
    }
}