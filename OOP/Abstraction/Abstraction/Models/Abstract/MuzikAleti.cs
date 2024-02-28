using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models.Abstract
{
    // Abstraction => Soyutlama
    // Diğer class lara atalık yapmak için üretilemeyen kendisine nesne üretilemeyen class lara abstract class lar denir.
    // Abstract class ların tek amacı diğer class lara miras vermektir. Bu yüzden child classlardaki ortak özellikler Base Class olarak tanımladığımız abstract class ta bulunur.
    // Abstract class lar soyut classs lar oldukları için kendilerinden nesne üretilemez!!!! (newlemek)
    public abstract class MuzikAleti
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public double Fiyat { get; set; }
        public string Aciklama { get; set; }
        // Abstract olarak işaretlenmiş tüm yapılar mutlaka override edilmek zorundadır. Abstract class ların en büyük özelliği içinde Abstract olan ya da olmayan methodarı barındırabilmesidir.
        // Abstract methodlar kalıtım aldığı class ta implement edilerek kullanılacak olan methodlardır yani tanımlandığı yerlerde herhangi bir kod bloğu(body si) bulundurmazlar.
        public abstract string Cal();

    }
}
