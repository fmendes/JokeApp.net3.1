using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity; // .EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JokeApp.net3._1.Models;

namespace JokeApp.net3._1.Data
{
    public class ApplicationDbContext : DbContext // : IdentityDbContext
    {
        public ApplicationDbContext() : base()
        {
        }
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ) : base( options )
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    // Customize the ASP.NET Core Identity model and override the defaults if needed.
        //    // For example, you can rename the ASP.NET Core Identity table names and more.
        //    // Add your customizations after calling base.OnModelCreating(builder);
        //}

        public DbSet<JokeApp.net3._1.Models.Joke> Joke { get; set; }
        //public DbSet<JokeApp.net3._1.Models.ApplicationUser> ApplicationUser { get; set; }
    }
}
