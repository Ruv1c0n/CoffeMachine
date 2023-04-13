using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Beverage
{
    class Cappuccino : BeverageBase
    {
        public Cappuccino()
        {
            DESCRIPTION = "Каппучино";
        }

        public override double GetCost()
        {
            return 60;
        }
    }
}
