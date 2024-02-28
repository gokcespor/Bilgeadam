using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models.Interface
{
    public interface IFutbolcu
    {
        string AdiSoyadi { get; set; }
        byte FormaNumarasi { get; set; }
        byte SutGucu { get; set; }
        byte Refleks { get; set; }
        byte Agresiflik { get; set; }
        byte Hiz { get; set; }



        void SutCek();
        void TopKurtar();

    }
}
