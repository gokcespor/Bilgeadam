using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.BadExample.Abstract
{
    public abstract class Car
    {
        public string Run()
        {
            return "Araba çalıştırıldı.";
        }

        public abstract string OpenAirConditioning();
    }
}
