using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Beverage
{
    class Маккиато : BeverageBase
    {
        public Маккиато()
        {
            DESCRIPTION = "Маккиато";
        }

        public override double GetCost()
        {
            return 100;
        }
    }
}
