using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedYapisi
{
    public class Book : BaseBook
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string YazarAdi { get; set; }
        public override void SatisYap()
        {
            Console.WriteLine("Kitap satışı yapıldı");
        }
 
        public sealed override void Kirala()
        {
            Console.WriteLine("Kitap kiralaması yapıldı...");
        }
    }
}
