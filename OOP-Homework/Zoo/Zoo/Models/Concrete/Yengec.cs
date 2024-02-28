using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Models.Interface;

namespace Zoo.Models.Concrete
{
    public class Yengec : IHayvan
    {
        private byte _kos;

        public string YemekYe { get; set; }
        public string Otur { get; set; }
        public byte Yuru { get; set; }
        public byte Kos
        {
            get => _kos;
            set
            {
                if (value > 50)
                {
                    Console.WriteLine("Yengeçler koşamazlar ama hızlı hareket ederler.");
                }
                else
                {
                    _kos = value;
                }
            }
        }

        public void Kosma()
        {
            Console.WriteLine("Yengeçler koşamazlar.");
        }

        public void Oturma()
        {
            Console.WriteLine("Yengeçler oturamazlar..");
        }
        public override string ToString()
        {
            return $"Yemek: {YemekYe}\nOtur: {Otur}\nYürü: {Yuru}\nKoş: {Kos}";
        }
    }
}
