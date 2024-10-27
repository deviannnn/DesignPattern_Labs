using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageDecorator
{
    public class BeverageFactory
    {
        public static Beverage CreateBeverage(int type)
        {
            return type switch
            {
                0 => new Coffee(),
                1 => new Tea(),
                _ => new Coffee(),
            };
        }

        public static CondimentDecorator CreateCondiment(int type, Beverage wrabObj)
        {
            return type switch
            {
                0 => new Pearl(wrabObj),
                1 => new FreshMilk(wrabObj),
                _ => new Aloe(wrabObj),
            };
        }
    }
}
