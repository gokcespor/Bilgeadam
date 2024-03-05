using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheChainOfResponsibility.Abstract;

namespace TheChainOfResponsibility.Concrete
{
    public class HandlerAVI : PlayerHandler
    {
        public override void Player(string fileType)
        {
            if (fileType.EndsWith(".avi"))
            {
                Console.WriteLine("AVI tipindeki medya oynatılıyor...");
            }
            else
            {
                Console.WriteLine("Bizde oynatılacak sistem yok. Lütfen başka zincirlere bakınız!!!");
            }
        }
    }
}
