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
        private string _name;
        private string _surname;
        private int _yas;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public int Yas 
        { 
            get => _yas; 
            set
            {
                if(value > 0)
                {
                    _yas = value;
                }
                else
                {
                    Console.WriteLine("Yaş negatif olamaz.");
                }
            }
        }
    }
}
