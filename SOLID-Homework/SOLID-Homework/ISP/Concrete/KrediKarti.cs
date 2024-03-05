using ISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Concrete
{
    public class KrediKarti : ITemassiz, ISifreli
    {
        public void Sifreli()
        {
            Console.WriteLine("Kredi kartıyla şifre kullanarak alış verişinizi yapabilirsiniz.");
        }

        public void Temassiz()
        {
            Console.WriteLine("Kredi kartının temazsız özelliğiyle alış veriş yapabilirsiniz");
        }
    }
}
