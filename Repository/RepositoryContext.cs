using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Users>? Users { get; set; }
        public DbSet<AboutMe>? AboutMe { get; set; }
        public DbSet<ProjectPhotos>? ProjectPhotos { get; set; }
        public DbSet<Projects>? Projects { get; set; }
        public DbSet<Quotes>? Quotes { get; set; }
        public DbSet<Skills>? Skills { get; set; }
        public DbSet<Technologies>? Technologies { get; set; }
    }
}
