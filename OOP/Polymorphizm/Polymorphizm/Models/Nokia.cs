﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm.Models
{
    public class Nokia : BasePhone
    {
        public override void ZilSesiCal()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\Sesler\nokia.wav"))
            {
                player.PlaySync();
            }
        }
    }
}
