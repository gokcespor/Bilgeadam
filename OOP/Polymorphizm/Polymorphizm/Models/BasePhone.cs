using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm.Models
{
    // Polymorphizm (Çok biçimlilik) => Üst sınıftaki methodların alt sınıflarda farklı biçimlere girebilmesidir. (Polymorphizm = (virtual(sanal) + override(üstüne yazmak)))
    public class BasePhone
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }
        public virtual void ZilSesiCal()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\Sesler\default.wav"))
            {
                player.PlaySync();
            }
        } 

    }
}
