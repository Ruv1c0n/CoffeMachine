using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Beverage
{
    class Doppio : BeverageBase
    {
        public Doppio()
        {
            DESCRIPTION = "Доппио";
        }

        public override double GetCost()
        {
            return 55;
        }
    }
}
