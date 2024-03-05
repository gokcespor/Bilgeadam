using DIP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Concrete
{
    public class Pediatri : IDepartman
    {
        public string DepartmanInfo()
        {
            return "Pediatride çocuklara bakılır...";
        }
    }
}
