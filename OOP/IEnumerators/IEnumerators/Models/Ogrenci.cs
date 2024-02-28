using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerators.Models
{
    public enum Bolum { Yazilim, Bilisim, Muhendislik, Mimarlik }
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public Bolum Bolum { get; set; }
        public override string ToString()
        {
            return $"Ad: {Ad}\nSoyad: {Soyad}\nYaş: {Yas}\nBölüm: {Bolum}\n===============";
        }
    }
}
