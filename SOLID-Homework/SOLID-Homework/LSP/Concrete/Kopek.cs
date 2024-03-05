using LSP.Abstract;
using LSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Concrete
{
    public class Kopek : Hayvan, IHavlama
    {
        public string Havlama()
        {
            return "Köper havlar.";
        }
    }
}
