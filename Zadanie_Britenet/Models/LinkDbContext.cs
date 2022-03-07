using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GetHTMLCodeAndImgsFromWebPage.Models
{
    public class LinkDbContext:DbContext
    {
        public DbSet<Link> Links { get; set; }

        public LinkDbContext()
        {

        }
        public LinkDbContext(DbContextOptions opt)
            : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
