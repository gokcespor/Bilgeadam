using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedYapisi
{
    // Eğer ki bir class sealed olarak işaretlenirse (yani mühürlenirse) artık kimseye miras veremez.
    public sealed class Novel : Book
    {
        public int SayfaSayisi { get; set; }
        public override void SatisYap()
        {
            Console.WriteLine("Roman satışı yapıldı!!");
        }


        // Kirala methodunu tekrar override edemem. Çünkü Book classında bu methodu mühürledim. (Sealed olarak işaretledim)
        //public override void Kirala()
        //{
        //    Console.WriteLine("Roman kiralaması yapıldı!!");
        //}
    }
}
