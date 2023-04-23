using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Beverage
{
    class Latte : BeverageBase
    {
        public Latte()
        {
            DESCRIPTION = "Латте";
        }

        public override double GetCost()
        {
            return 80;
        }
        public override double Cost()
        {
            return 80;
        }
    }
}
