using Abstraction.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models.Concrete
{
    public class Muzisyen 
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public MuzikAleti CaldigiEnstruman { get; set; }
    }
}
