using LINQ_Operations.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Operations.Infrastructure.SeedData
{
    public class SeedBook : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
                (
                new Book { Id = 1, Title = "Beyaz Diş", Price = 50.5, GenreId = "macera" },
                new Book { Id = 2, Title = "Suç ve Ceza", Price = 91.45, GenreId = "roman" },
                new Book { Id = 3, Title = "1984", Price = 100, GenreId = "korku" },
                new Book { Id = 4, Title = "Sakın Yalan Söyleme", Price = 150.8, GenreId = "polisiye" },
                new Book { Id = 5, Title = "Savaş ve Barış", Price = 200, GenreId = "roman" },
                new Book { Id = 6, Title = "Tutunamayanlar", Price = 82, GenreId = "ask" },
                new Book { Id = 7, Title = "Beyaz Geceler", Price = 75, GenreId = "roman" },
                new Book { Id = 8, Title = "İnsan Ne ile Yaşar", Price = 50, GenreId = "roman" },
                new Book { Id = 9, Title = "Harry Potter Azkaban Tutsağı", Price = 80, GenreId = "bilimkurgu" }
                );
        }
    }
}
