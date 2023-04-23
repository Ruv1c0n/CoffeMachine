using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Beverage
{
    class Macciato : BeverageBase
    {
        public Macciato()
        {
            DESCRIPTION = "Маккиато";
        }

        public override double GetCost()
        {
            return 100;
        }
    }
}
