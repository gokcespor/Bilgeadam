using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    /*
     * ENCAPSULATION
     * 
     * Nesnenin üyelerine yapılan erişimin kontrol altına alınmasına ve bu kontrolün nesnenin kendisi tarafından yapılmasını sağlamaktır. Ama field'ları private yaparak bu alanlara dışarıdan erişmi önlemek ve get-set methodları ile kontrolü sağlamaktır.
     * 
     * Class ile ilgili işlemler class'ın içinde olmak zorundadır.
     */
    public class Urun
    {
        private int _id;
        public int Id { get => _id; set => _id = value; }
        private string _ad;
        public string Ad { get => _ad; set => _ad = value; }
        private double _fiyat;
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
                    Console.WriteLine("Fiyat negatif olamaz!");
                }
            }
        }

    }
}
