using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    // Static Class
    //Eğer nesneye bağımlı işlemler gerçekleştirmiyorsanız - yani amaç belirli bir duruma hizmet eden birden fazla öğeyi bir araya toplamak ise - ilgli sınıfı static olarak işaretleyebilirsiniz ve içerisinde tüm öğelere instance dan (new leme) bağımsız olarak ulaşılabilir.

    // Static Sınıflar içinde sadece static öğeler bulundururlar. (field, property, method...)
    // Static sınıflar başka bir sınıftan mirass alamazlar.
    // Static sınıflara en güzel iki örnek Math ve File class larıdır. Aynı amaca hizmet eden(Math => Matematiksel işlemlerin bir arada )
    public static class FizikKutuphanesi
    {
        public static decimal YerCekimiKuvveti { get => 9.80665M; }

        // const => Sabit değer. Kendiliğinden static olma özelliğine sahiptir, dolayısıyla static olarak işaretlemeye gerek yoktur.
        public const int KaldirmaKuvveti = 12;

        // readonly => Sadece okunabilir değişkenler oluşturmak için kullanılır.
        public static readonly int IndermeKuvveti = 2;

        public static void Kaldir()
        { 
        
        
        
        }


    }
}
