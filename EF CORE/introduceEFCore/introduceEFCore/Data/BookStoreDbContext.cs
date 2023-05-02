using introduceEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace introduceEFCore.Data
{
    public class BookStoreDbContext : DbContext
    {

        //public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        //{

        //}

        public BookStoreDbContext()
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=bookStoreSampleDb;Integrated Security=yes";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Model sınıflarınız (POCO) db'ye aktarılırken, nasıl bir ilişki kurulacak?
            modelBuilder.Entity<Book>().Property(b => b.Title).IsRequired()
                                                              .HasMaxLength(250);

            modelBuilder.Entity<Book>().Property(b => b.Description).HasMaxLength(250);

            modelBuilder.Entity<Review>().HasOne(r => r.Book)
                                         .WithMany(b => b.Reviews)
                                         .HasForeignKey(r => r.BookId)
                                         .OnDelete(DeleteBehavior.Restrict);








        }
    }
}
