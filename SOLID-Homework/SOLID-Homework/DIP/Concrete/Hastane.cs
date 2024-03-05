using DIP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Concrete
{
    public class Hastane : IDepartman
    {
        private readonly IDepartman _departman;

        public Hastane(IDepartman departman)
        {
            _departman = departman;
        }
        public string DepartmanInfo()
        {
            return _departman.DepartmanInfo();
        }
    }
}
