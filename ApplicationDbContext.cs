using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoTutorial.Model;
using VideoTutorial.Models;

namespace VideoTutorial.Repository
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set;}
        public DbSet<Category> Categories { get; set;}
        public DbSet<Course> Courses { get; set;}
        public DbSet<Lacture> Lactures { get; set;}
        public DbSet<NavItems> NavItems { get; set;}
        public DbSet<LactureTutorial> LactureTutorials { get; set;}

    }
}
