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
    public class SeedAuthor : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData
                ( 
                new Author { Id = 1, FirstName = "Jack", LastName = "London"},
                new Author { Id = 2, FirstName = "George", LastName = "Orwell"},
                new Author { Id = 3, FirstName = "Freida", LastName = "McFadden"},
                new Author { Id = 4, FirstName = "Lev", LastName = "Tolstoy"},
                new Author { Id = 5, FirstName = "Oğuz", LastName = "Atay"},
                new Author { Id = 6, FirstName = "Mihailovic", LastName = "Dostoyevski"},
                new Author { Id = 7, FirstName = "J.K.", LastName = "Rowling"}
                );
        }
    }
}
