using LINQ_Operations.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Operations.Models.Concrete
{
    public class Book : BaseEntity<int>
    {
        public override int Id { get ; set ; }
        public string Title { get; set; }
        public double Price { get; set; }

        // One to Many ilişkisinde çok kısımda bir kısmın Id si ve nesnesi tutulur.
        // 1 kısmında ise çok kısmın listesi tutulur
        public string GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }

    }
}
