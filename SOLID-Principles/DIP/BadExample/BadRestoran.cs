using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.BadExample
{
    public class BadRestoran
    {
        BadFish badFish = new BadFish();
        BadChicken badChicken = new BadChicken();
        public string GetMenu()
        {
            return $"Menü\n{badChicken.GetChickenInfo()}\n{badFish.GetFishInfo()}";
        }
    }
}
