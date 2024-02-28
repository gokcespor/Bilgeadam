using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Models.Interface;

namespace Zoo.Models.Concrete
{
    public class Kopek : IHayvan
    {
        public string YemekYe { get; set; }
        public string Otur { get; set; }
        public byte Yuru { get; set; }
        public byte Kos { get; set; }

        public void Kosma()
        {
            Console.WriteLine("Köpek boyutuna bağlı olarak hızlı koşar.");
        }

        public void Oturma()
        {
            Console.WriteLine("Köpekler eğitimle oturtulabilir.");
        }

        public override string ToString()
        {
            return $"Yemek: {YemekYe}\nOtur: {Otur}\nYürü: {Yuru}\nKoş: {Kos}";
        }
    }
}
