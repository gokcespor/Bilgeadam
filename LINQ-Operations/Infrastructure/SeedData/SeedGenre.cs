using LINQ_Operations.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Operations.Infrastructure.SeedData
{
    public class SeedGenre : IEntityTypeConfiguration<Genre>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Genre> builder)
        {
            builder.HasData
                (
                new Genre { Id = "roman", Name = "Roman"},
                new Genre { Id = "korku", Name = "Korku"},
                new Genre { Id = "polisiye", Name = "Polisiye"},
                new Genre { Id = "bilimkurgu", Name = "Bilim Kurgu"},
                new Genre { Id = "ask", Name = "Aşk"},
                new Genre { Id = "macera", Name = "Macera" }
                );

        }
    }
}
