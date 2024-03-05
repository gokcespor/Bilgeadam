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
    public class SeedBookAuthor : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasData
                (
                new BookAuthor { BookId = 1, AuthorId = 1 },
                new BookAuthor { BookId = 2, AuthorId = 4 },
                new BookAuthor { BookId = 3, AuthorId = 2 },
                new BookAuthor { BookId = 4, AuthorId = 3 },
                new BookAuthor { BookId = 5, AuthorId = 4 },
                new BookAuthor { BookId = 6, AuthorId = 5 },
                new BookAuthor { BookId = 7, AuthorId = 6 },
                new BookAuthor { BookId = 8, AuthorId = 4 },
                new BookAuthor { BookId = 9, AuthorId = 7 }
                );

        }
    }
}
