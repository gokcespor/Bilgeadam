using Abstraction.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models.Concrete
{
    public class YanFlut : MuzikAleti
    {
        public override string Cal()
        {
            return "Yan flüt sesi...";
        }
    }
}
