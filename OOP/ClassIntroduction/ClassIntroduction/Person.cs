using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntroduction
{
    /*
     * Object(Nesne) Nedir? 
     * Özellikleri ve eylemleri olan class ile üretilen yapılara nesne(object) denir.
     * 
     * Class Nedir? 
     * Sınıf(Class) nesnelerin şablonudur. Class içerisinde nesnelerin durumları ile ilgili işlem ve özellikler tanımlanır.
     * 
     * Field Nedir?
     * Class yada struct içerisinde tanımlanan dışarıya kapalı değişkenlerdir. Field değişkenler tanımlanırken erişim belirteci, tipi ve isimi şeklinde tanımlanı. Kültür olarak "_" ile başlar ve camelCase yazım şekli ile devam eder.
     * 
     * Property Nedir?
     * Property field'a değer atamak ve field'daki değeri okumak için kullanılan aracı bir yapıdır. Property bir değer ataması gerçekleştirirken SET methodu, Property içinde değeri okumak için ise GET methodu çalışır.
     */
    public class Person
    {
        private int _id; // Field
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _tC;
        private int _weight;
        private int _height;

        public int Id { get => _id; set => _id = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age { get => _age; set => _age = value; }
        public string TC { get => _tC; set => _tC = value; }
        public int Weight { get => _weight; set => _weight = value; }
        public int Height { get => _height; set => _height = value; }
    }
}
