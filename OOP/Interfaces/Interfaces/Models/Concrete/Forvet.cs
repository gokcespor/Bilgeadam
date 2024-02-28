using Interfaces.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models.Concrete
{
    public class Forvet : IFutbolcu
    {
        public string AdiSoyadi { get; set; }
        public byte FormaNumarasi { get; set; }
        public byte SutGucu { get; set; }
        public byte Refleks { get; set; }
        public byte Agresiflik { get; set; }
        public byte Hiz { get; set; }

        public void SutCek()
        {
            Console.WriteLine("Forvet futbolcusu şut çekiyor...");
        }

        public void TopKurtar()
        {
            Console.WriteLine("Forvet futbolcusu kurtaramıyor çünkü kendisi bir kaleci değil!");
        }

        public override string ToString()
        {
            return $"Futbolcu: {AdiSoyadi}\nŞut Gücü: {SutGucu}\nRefleks: {Refleks}\nAgresiflik: {Agresiflik}\nForma Numarası: {FormaNumarasi}\nHız: {Hiz}";
        }
    }
}
