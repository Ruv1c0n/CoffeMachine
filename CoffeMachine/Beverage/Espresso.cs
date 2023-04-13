using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Beverage
{
    class Espresso : BeverageBase
    {
        public Espresso()
        {
            DESCRIPTION = "Эспрессо";
        }

        public override double GetCost()
        {
            return 40;
        }
    }
}
