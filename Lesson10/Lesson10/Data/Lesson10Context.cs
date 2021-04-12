using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lesson10.Models;

namespace Lesson10.Data
{
    public class Lesson10Context : DbContext
    {
        public Lesson10Context(DbContextOptions<Lesson10Context> options)
            : base(options)
        {
        }
        
        public DbSet<Lesson10.Models.Author> Author { get; set; }
        public DbSet<Lesson10.Models.Book> Book { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().Property(a => a.Name).IsRequired();
            modelBuilder.Entity<Author>().Property(a => a.Name).HasMaxLength(50);
            modelBuilder.Entity<Author>().HasIndex(p => p.Name).IsUnique();
            
            modelBuilder.Entity<Book>().Property(b => b.Title).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.Title).IsRequired();
            

        }
    }
}
