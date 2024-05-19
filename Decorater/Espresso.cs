using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorater
{
    public class Espresso : ICoffee
    {

        public double GetPrice()
        {
            return 1.99;
        }

        public String GetDescription()
        {
            return "Espresso";
        }
    }
}
