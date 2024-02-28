using Interfaces.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models.Concrete
{
    public class Kaleci : IFutbolcu
    {
        private byte _sutGucu;

        public string AdiSoyadi { get; set; }
        public byte FormaNumarasi { get; set; }
        public byte SutGucu
        {
            get => _sutGucu;
            set
            {
                if (value > 70)
                {
                    Console.WriteLine("Şut gücü 70 den büyük olamaz.");
                }
                else
                {
                    _sutGucu = value;
                }
            }
        }
        public byte Refleks { get; set; }
        public byte Agresiflik { get; set; }
        public byte Hiz { get; set; }

        public void SutCek()
        {
            Console.WriteLine("Kaleci şut çekemez...");
        }

        public void TopKurtar()
        {
            Console.WriteLine($"Kaleci {Refleks} refleks gücü ile top kurtarır...");
        }

        public override string ToString()
        {
            return $"Futbolcu: {AdiSoyadi}\nŞut Gücü: {SutGucu}\nRefleks: {Refleks}\nAgresiflik: {Agresiflik}\nForma Numarası: {FormaNumarasi}\nHız: {Hiz}";
        }
    }
}
