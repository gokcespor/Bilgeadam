using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /*
     * INHERITANCE(Kalıtım)
     * 
     * Bir class'ın bütün özelliklerini başka bir class'a miras verme olayıdır. Ata class'ta(Parent Class) yer alan property, field ve methodların Çocuk Class'lara(Child Class) aktrılmasıdır.
     */
    public class BasePhone
    {
        //Kısayol ctor + tab
        //public BasePhone()
        //{
            
        //}

        public BasePhone(string marka, string model, double fiyat)
        {
            Marka = marka;
            Model = model;
            Fiyat = fiyat;
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }

        //Virtual Methods(Sanal methodlar), base class(temel sınıf) içinde bildirilmiş ve derived class(türemiş sınıf) içinde de tekrar bildirilebilen ya da değiştirilebilen methodlardır. Böylelikler sanal methodlar kullanılarak nesne yönelimli programla(OOP-Object Oriented Programming) da çok sık başvurulan ilerde göreceğiniz polimorfizm prensibi uygulanmış olur. Yani temel sınıfta bir sanal method bildirildiğinde bu temel sınıftan türeeyen sınıflardaki methodlar override edilerek, temel sınıftaki sanal method devre dışı bırakabilirler..
        public virtual string ZilSesiCal()
        {
            return "Default ses çalınıyor...";
        }
    }
}
