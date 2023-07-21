using BookApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<PriceOffer> Prices { get; set; }
        public DbSet<Tag> Tags { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=BookApp;Username=postgres;Password=26032005");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBook>()
                .HasOne(book => book.Book)
                .WithMany(book => book.AuthorLink)
                .HasForeignKey(book => book.BookId);

            modelBuilder.Entity<AuthorBook>()
                .HasOne(a => a.Author)
                .WithMany(a => a.AuthorBook)
                .HasForeignKey(a => a.AuthorId);

            modelBuilder.Entity<AuthorBook>()
                .HasKey(a => new { a.AuthorId, a.BookId });

            modelBuilder.Entity<Book>()
                .HasMany(a => a.Reviews);

            modelBuilder.Entity<Book>()
                .HasOne(a => a.Promotion);

            modelBuilder.Entity<Book>()
                .HasMany(a => a.Tags);
            
        }
    }
}
 