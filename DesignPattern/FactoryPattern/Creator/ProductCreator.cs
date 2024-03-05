﻿using FactoryPattern.Concrete;
using FactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Creator
{
    public class ProductCreator
    {
        public IProduct FactoryMethod(int month)
        {
            if (month >= 4 && month <= 11)
            {
                return new Product_A();
            }
            else if (month == 3)
            {
                return new DefaultProduct();
            }
            else
                return new Product_B();
            
        }
    }
}
