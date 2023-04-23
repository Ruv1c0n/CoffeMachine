using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Beverage
{
    class Americano : BeverageBase
    {
        public Americano()
        {
            DESCRIPTION = "Американо";
        }

        public override double Cost()
        {
            return 50;
        }

        public override double GetCost()
        {
            return 50;
        }
    }
}
