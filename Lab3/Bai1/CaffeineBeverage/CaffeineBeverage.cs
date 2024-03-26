using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class CaffeineBeverage
    {
        public void prepareReceipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }

        public abstract void brew();

        public abstract void addCondiments();

        public void boilWater()
        {
            Console.WriteLine("Boil water");
        }

        public void pourInCup()
        {
            Console.WriteLine("Pour into cup");
        }
    }
}
