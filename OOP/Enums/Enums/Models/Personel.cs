using Enums.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums.Models
{
    public class Personel
    {
        private string _ad;
        private string _soyad;
        private Departmanlar _departman;

        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
        public Departmanlar Departman { get => _departman; set => _departman = value; }
    }
}
