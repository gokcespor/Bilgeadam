using ISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Concrete
{
    public class Sodexo : ISifreli
    {
        public void Sifreli()
        {
            Console.WriteLine("Sodexo da şifre kullanarak ödemenizi yapabilirsiniz...");
        }
    }
}
