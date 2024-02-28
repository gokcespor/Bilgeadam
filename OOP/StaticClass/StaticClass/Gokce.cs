using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class Gokce
    {
        public static string Ad { get => "Gökçe"; }
        public static string Soyad { get => "Spor Alagöz"; }
        public const string DogumTarihi = "22.05.1991";
        public static string YasSoyle()
        {
            return "Yaşım 28";
        }
    }
}
