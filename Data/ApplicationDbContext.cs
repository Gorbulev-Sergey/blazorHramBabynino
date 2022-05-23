using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using blazorHramBabynino.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace blazorHramBabynino.Data
{
    public class ApplicationDbContext : IdentityDbContext<user>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<user> AspNetUsers { get; set; }
        public DbSet<IdentityRole> ASPNetRoles { get; set; }
        public DbSet<IdentityUserRole<string>> ASPNetUserRoles { get; set; }

        public DbSet<post> posts { get; set; }
        public DbSet<comment> comments { get; set; }
        public DbSet<like> likes { get; set; }
        public DbSet<tag> tags { get; set; }
        public DbSet<imageAlbum> imageAlbums { get; set; }
        public DbSet<schedule_string> schedule { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
