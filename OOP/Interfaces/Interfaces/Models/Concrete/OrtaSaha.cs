using Interfaces.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models.Concrete
{
    public class OrtaSaha : IFutbolcu
    {
        private byte _agresiflik;

        public string AdiSoyadi { get; set; }
        public byte FormaNumarasi { get; set; }
        public byte SutGucu { get; set; }
        public byte Refleks { get; set; }
        public byte Agresiflik
        {
            get => _agresiflik;
            set
            {
                if (value >= 70)
                {
                    Console.WriteLine("Agresiflik 70 ten büyük olamaz.");
                }
                else
                {
                    _agresiflik = value;    
                }
            }
        }
        public byte Hiz { get; set; }

        public void SutCek()
        {
            Console.WriteLine($"Orta saha futbolcusu {SutGucu} şut gücü ile şut çekiyor...");
        }

        public void TopKurtar()
        {
            Console.WriteLine("Orta saha futbolcusu kurtaramıyor çünkü kendisi bir kaleci değil!");
        }

        public override string ToString()
        {
            return $"Futbolcu: {AdiSoyadi}\nŞut Gücü: {SutGucu}\nRefleks: {Refleks}\nAgresiflik: {Agresiflik}\nForma Numarası: {FormaNumarasi}\nHız: {Hiz}";
        }
    }
}
