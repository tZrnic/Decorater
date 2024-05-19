using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorater
{
    public class Milk : CoffeeDecorator
    {

        public Milk(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return coffee.GetDescription() + " with Milk";
        }

        public override double GetPrice()
        {
            return coffee.GetPrice() + 0.5;
        }
    }
}
