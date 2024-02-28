using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums.Enums
{
    /*
     * Kişilere sabit seçenekler sunmak için kullanılan bir değer tipidir. Seçenekleri kontrol altında tutup, uygulamanızı da kontrolünüz çerçeesine yönetebilirsiniz. Bu sebeple uygulamanızda herhangi bir sürprize yer vermemek için çok daha performanslı ve çok daha güvenli bir yapıyı oluşturmuş olursunuz.
     * 
     * Enumlar geliştiriciye (developer a) yönelik nesnelerdir.
     * Bir ENUM ın yazılı değerlerini teslim alabilmek için kullanılan method Enum.GetNames() methodudur.
     * 
     * Yazılı hale getirilmiş bir ENUM değerini, tekrar ENUM şeklinde geri alabilmek için kullanılan methodsa Enum.Parse() methodudur.
     * 
     * Bir ENUM arka planda sayısal değerler tutar bu değerler varsayılan olarak seçilen index değeridir ve veri tipi int tir. Ancak siz isterseniz bu tipi değiştirebilirsiniz. Ya da istediğiniz değerden başlatabilir (ilk eleman 5 olsun sonrakileri enum atasın) ya da bütün enum değerlerine tek tek değer atayabilirsiniz. Benzersizlik diye bir kavram yoktur.
     * Bu arkaplandaki değerden ötürü ENUM.Parse işlemi size object tipinde değer döner. Yazılı haline teslim almak için o enum un tipine, sayısdal değerini almak için ise hangi tipte tanımladıysanız o tipe cast etmeniz gerekiyor.
     */
    public enum Departmanlar
    {
        Yazilim = 1, SistemAgUzmanligi, GrafikTasarim, Ingilizce, Muhasebe
    }
}
