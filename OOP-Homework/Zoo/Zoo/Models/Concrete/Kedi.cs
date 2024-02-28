using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Models.Interface;

namespace Zoo.Models.Concrete
{
    public class Kedi : IHayvan
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
                if (value > 120)
                {
                    Console.WriteLine("Kedi Köpek kadar hızlı koşamaz.");
                }
                else
                {
                    _kos = value;   
                }
            }
        }

        public void Kosma()
        {
            Console.WriteLine("Kedinin bacak boyu kısa olduğundan çok hızlı koşamaz..");
        }

        public void Oturma()
        {
            Console.WriteLine("Kediler seçicidir. Her yere oturmazlar.");
        }

        public override string ToString()
        {
            return $"Yemek: {YemekYe}\nOtur: {Otur}\nYürü: {Yuru}\nKoş: {Kos}";
        }
    }
}
