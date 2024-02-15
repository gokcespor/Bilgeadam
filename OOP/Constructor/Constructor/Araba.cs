using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    /*
     * Constructor - Yapıcı Methodlar
     * 
     * Yapıcı methodlardan kısaca bahsedersek, statik olmayan(ilerde öğreneceğiz) bir sınıf içerisindeki property'lere(özelliklere) sınıfın instance(new'leme) alımı esnasında değerler verme işlemidir. Bu methodlar tıpkı void methodlar gibi çalışır ve geriye herhangi bir tipte(int, string...) değer döndürmezler. Ancak bu methodun bir adı da olmaz çünkü yapıcı methodlar sınıfın birebir kendi adıyla yazılmak zorundadır.
     */
    public class Araba

    {
        public Araba()
        { 
        }
        public Araba(string marka, string model, double motor)
        {
            Marka = marka;
            Model = model;
            Motor = motor;

        }
        public string Marka { get; set; }
        public string Model{ get; set;}      
        public double Motor { get; set; }
    }
}
