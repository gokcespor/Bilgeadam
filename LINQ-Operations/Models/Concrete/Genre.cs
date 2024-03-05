using LINQ_Operations.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Operations.Models.Concrete
{
    public class Genre : BaseEntity<string>
    {
        public override string Id { get ; set; }
        public string Name { get; set; }
        // One to Many ilişkisinde 
        public List<Book> Books { get; set; }
    }
}
