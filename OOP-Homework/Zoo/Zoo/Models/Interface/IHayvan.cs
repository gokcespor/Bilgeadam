using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models.Interface
{
    public interface IHayvan
    {
        string YemekYe { get; set; }
        string Otur { get; set; }
        byte Yuru { get; set; }
        byte Kos { get; set; }

        void Oturma();
        void Kosma();

    }
}
