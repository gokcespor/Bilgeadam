using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace HayvanSesi.Models
{
    public class Dog : BaseVoice
    {
        public override void Ses()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\HayvanSesleri\dog.wav"))
            {
                player.PlaySync();
            }
        }
    }
}
