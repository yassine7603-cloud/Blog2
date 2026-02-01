using Blog2.Models;
using Blog2.Models.Developpement_Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog2.Data
{
    public class BlogDbContext : DbContext
    {

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }
        
        public DbSet<Comment> comments { get; set; }
        // ✅ AJOUTE CETTE LIGNE ICI :
        public DbSet<Comment> Comments { get; set; }

    }
}
