﻿using DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.GoodExample.Concrete
{
    public class GoodFish : IProduct
    {
        public string GetCookingInfo()
        {
            return "Balık tarifleri...";
        }
    }
}
