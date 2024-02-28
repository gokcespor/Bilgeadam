using LSP.BadExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.BadExample.Concrete
{
    public class Murat131 : Car
    {
        public override string OpenAirConditioning()
        {
            //throw new NotImplementedException();
            return null;
        }
    }
}
