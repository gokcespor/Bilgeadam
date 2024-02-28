using DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.GoodExample.Concrete
{
    
    public class GoodRestoran
    {
        private readonly IProduct _product;

        // Bu işlemin adı (constructor da Interace i çağırıp, özelliklerini bir field a aktarma) Dependency Injection işlemidir.

        public GoodRestoran(IProduct product)
        {
            _product = product;
        }
        public string GetProductInfo()
        {
            return _product.GetCookingInfo();
        }
    }
}
