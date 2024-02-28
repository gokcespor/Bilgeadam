using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueTypes
{
    /*
     * ASP .NET Core mantığı gereği, uygulama üzerinde geçici olarak kullanılan tüm nesneler RAM üzerinde kendilerine bir yer edinirler. RAM'in teknik yapısına baktığımızda ise bu nesnleri iki farklı blokta tuttuğunu görürüz.
     * Bunlarda bir tane STACK, diğeri ise HEAP alanıdır.
     * 
     * STACK bölümünde ValueType olarak adlandırdığımız değer tipleri bulunur.(String hariç tüm değişkenler, Enum, Struct)
     * HEAP bölümünde ise ReferenceType olarak adlandırdığımız tipler bulunur.(Class, Array, String, Delegate)
     * 
     * Value Type'ların değerleri kopyalanabilme özelliğine sahipken, referans tiplerde ise bu iş değer taşıma oalrak gözlemlenmektedir. 
     * Bir değerin NULL olması demek, o değerin HEAP bölümünde karşılığı olmaması demektir. Dolayısıyla Referans Tipler NULL geçilebilirken, Değer tipler NULL geçilemez.
     * 
     * NOT:
     * Value Type: Value tipindeki bir nesne tüm veriyi kendi içinde tutar.
     * Reference Type: Direkt olarak veriyi tutmaz bunun yerine adresini gösteren bir referans tutar.
     */

    public class Ogrenci
    {
        private string _ad;
        private string _soyad;

        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
    }

    
    public struct Student
    {
        //Struct => En basit tanımıyla class'ların değer tipi (Value Type) versiyonlarıdır. 
        //Eğer struct ile class arasında kalırsanır, değer tip ile referans tip olması bakımında da bir problem teşkil etmiyorsa 16 KB'dan büyük nesneler için CLASS, küçük nesneler için STRUCT kullanılması önerilmektedir.

        private string _firstName;
        private string _lastName;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
    }
}
