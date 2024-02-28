using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueTypes
{
    public class Ogrenci
    {
        private string _ad;
        private string _soyad;

        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
    }
    public struct Student
    {
        private string _firstName;
        private string _lastName;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
    }
}
