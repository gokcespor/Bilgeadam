using OCP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.GoodExample.Concrete
{
    public class Americano : GoodCoffeeShop
    {
        public override double GetTotalPrice(int quantity)
        {
            return 80 * quantity;
        }
    }
}
