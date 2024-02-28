using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace HayvanSesi.Models
{
    public class BaseVoice
    {
        public int Id { get; set; }
        public string Tur { get; set; }
        public virtual void Ses()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\HayvanSesleri\animals.wav"))
            {
                player.PlaySync();
            }
        }
    }

   
}
