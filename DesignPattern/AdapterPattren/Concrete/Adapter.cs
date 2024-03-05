using AdapterPattren.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattren.Concrete
{
    public class Adapter : IHedef
    {
        private readonly Bagdastirici _bagdastirici;

        public Adapter(Bagdastirici bagdastirici)
        {
            _bagdastirici = bagdastirici;
        }


        public string GetRequest()
        {
            return $"{_bagdastirici.GetSpecificRequest()}";
        }
    }
}
