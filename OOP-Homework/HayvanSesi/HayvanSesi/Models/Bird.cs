using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace HayvanSesi.Models
{
    public class Bird : BaseVoice
    {
        public override void Ses()
        {
           using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\HayvanSesleri\chirps.wav"))
           {
               player.PlaySync();
           }
        }
         
    }
}
