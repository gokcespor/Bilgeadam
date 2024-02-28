using LSP.BadExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.BadExample.Concrete
{
    public class Ferrari : Car
    {
        public override string OpenAirConditioning()
        {
            return "Klima açıldı!";
        }
    }
}
