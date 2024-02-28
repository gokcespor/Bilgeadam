using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Kisi
    {
        private int _id;
        private string _ad;
        private string _soyad;
        private int _yas;

        public int Id { get => _id; set => _id = value; }

        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }

        public int Yas 
        { 
            get => _yas;
            set 
            {
                if (value > 0)
                {
                     _yas = value;
                }
                else
                {
                    Console.WriteLine("Yaş 0'dan küçük olamaz!");
                }
            }
        }
    }
}
