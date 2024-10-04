using Microsoft.EntityFrameworkCore;
using SimplyBooks.Data;
using SimplyBooks.Models;
using System.Runtime.CompilerServices;


namespace SimplyBooks
{
    public class SimplyBooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public SimplyBooksDbContext(DbContextOptions<SimplyBooksDbContext> context) : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(BookData.Books);
            modelBuilder.Entity<Author>().HasData(AuthorData.Authors);

        }
    }
}
