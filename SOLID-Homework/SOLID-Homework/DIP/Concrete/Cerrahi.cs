using DIP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Concrete
{
    public class Cerrahi : IDepartman
    {
        public string DepartmanInfo()
        {
            return "Ameliyat gerektiren kişiler içindir...";
        }
    }
}
