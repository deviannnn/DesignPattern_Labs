using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Cofffee : CaffeineBeverage
    {
        public override void brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
        public override void addCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
