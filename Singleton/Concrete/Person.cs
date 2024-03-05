using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Singleton.Concrete
{
    public class Person
    {
        private static Person _person;

        private Person(){ } // Buradaki amaç bu sınıftan constructor ın dışarıdan erişimi kapatarak instance çıkarma işleminin kontrol altına akınmasıdır.


        // Bu sınıfın örneklemini dışarıdan alamayacağız çünkü constructor ı private yaptık, bunun yerine nesneyi sınıfın içerisinde kontrollü bir şekilde custom bir method ya da property üzerinden nesnenin üretimini kontrol altına alarak üretilmesini temin ettik.
        public static Person CreatePerson()
        {
            // Uygulamanın herhangi bir yerinde "Person.CreatePerson()" diyerek bu methodun çağrılmasını sağlayabiliriz. Bu method ise bana Person class ından bir nesneyi belirli bir şart doğrultusunda üreterek yaratır ya da var olanı teslim eder. 
            if (_person == null) // eğer _person field ının içerisi boşsa
            {
                _person = new Person(); // nesne üretir
            }

            // _person nesnesi zaten dolu ise direk bize onu teslim eder
            return _person; // nesne dönüşür
        }

        public void CreateLog() => Console.WriteLine("The log was created!");
    }
}
