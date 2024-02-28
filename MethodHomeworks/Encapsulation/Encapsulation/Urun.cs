using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Urun
    {
        private int _id;
        private string _adi;
        private double _fiyat;

        public int Id { get => _id; set => _id = value; }
        public string Adi { get => _adi; set => _adi = value; }
        public double Fiyat
        {
            get => _fiyat;
            set
            {
                if (value > 0)
                {
                    _fiyat = value;
                }
                else
                {
                    Console.WriteLine("Fiyat negatif olamaz.");
                }
            }
        }
    }
}
