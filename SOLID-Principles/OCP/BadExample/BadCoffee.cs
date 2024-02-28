using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.BadExample
{
    public enum CoffeeType { Latte = 1, Espresso, Americano}
    public class BadCoffee
    {
        public static double GetTotalPrice(double quantity, CoffeeType coffeeType)
        {
            double totalPrice = 0;

            if (coffeeType == CoffeeType.Latte)
            {
                totalPrice += quantity * 100;
            }

            if (coffeeType == CoffeeType.Espresso)
            {
                totalPrice += quantity * 70;
            }

            if (coffeeType == CoffeeType.Americano)
            {
                totalPrice += quantity * 80;
            }

            return totalPrice;
        }
    }
}
