using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionHomework
{
    public static class KisiExtension
    {
        public static string DogumGunuMesaji(this Kisi kisi)
        {
            return $"Doğum gününüz kutlu olsun. Nice mutlu yıllara {kisi.Ad} {kisi.Soyad}";
        }
    }
}
