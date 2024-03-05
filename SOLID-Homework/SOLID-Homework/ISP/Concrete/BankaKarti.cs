using ISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Concrete
{
    public class BankaKarti : ISifreli, ITemassiz
    {
        public void Sifreli()
        {
            Console.WriteLine("Banka kartıyla şifre kullanarak alış verişinizi yapabilirsiniz.");
        }

        public void Temassiz()
        {
            Console.WriteLine("Banka kartının temazsız özelliğiyle alış veriş yapabilirsiniz");
        }
    }
}
