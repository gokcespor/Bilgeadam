using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm.Models
{
    public class AttackOnTitan : BasePhone
    {
        public override void ZilSesiCal()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\Sesler\attack-on-titan.wav"))
            {
                player.PlaySync();
            }
        }
    }
}
