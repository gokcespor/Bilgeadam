using LINQ_Operations.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Operations.Models.Concrete
{
    public class Author : BaseEntity<int>
    {
        public override int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
