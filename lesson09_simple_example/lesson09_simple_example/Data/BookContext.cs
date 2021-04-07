using Microsoft.EntityFrameworkCore;
using WebApplication14.Models;

namespace lesson09_simple_example.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API mappings (if needed)
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Author>().ToTable("Author");

            //Configure Book Column
            modelBuilder.Entity<Book>()
                        .Property(b => b.PublishedOn)
                        .HasColumnType("datetime2");

            // Add example data (optional)

        }
    }
}
