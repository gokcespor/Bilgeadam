using LINQ_Operations.Infrastructure.SeedData;
using LINQ_Operations.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Operations.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books{ get; set; }
        public DbSet<Author> Authors{ get; set; }
        public DbSet<BookAuthor> BookAuthors{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Primary Key tanımlamaları
            modelBuilder.Entity<BookAuthor>().HasKey(x => new { x.BookId, x.AuthorId });

            // Foreign Key Tanımlama
            modelBuilder.Entity<BookAuthor>()
                .HasOne(x => x.Book)
                .WithMany(x => x.BookAuthors)
                .HasForeignKey(x => x.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(x => x.Author)
                .WithMany(x => x.BookAuthors)
                .HasForeignKey(x => x.AuthorId);

            // Cascade ilişkiyi silme(Tür silinirse o türe ait kitapların silinmesini sağlayacağız.)
            modelBuilder.Entity<Book>()
                .HasOne(x => x.Genre)
                .WithMany(x => x.Books)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.ApplyConfiguration(new SeedGenre());
            modelBuilder.ApplyConfiguration(new SeedBook());
            modelBuilder.ApplyConfiguration(new SeedAuthor());
            modelBuilder.ApplyConfiguration(new SeedBookAuthor());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localDb)\\MSSQLLocalDb;Database=KütüphaneDb; Trusted_Connection=True;");
        }
    }
}
