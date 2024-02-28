using LSP.GoodExample.AbstractGood;
using LSP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.GoodExample.ConcreteGood
{
    public class FerrariGood : GoodCar, IAirConditionable
    {
        public string OpenAirConditioning()
        {
            return "Klima açıldı";
        }
    }
}
