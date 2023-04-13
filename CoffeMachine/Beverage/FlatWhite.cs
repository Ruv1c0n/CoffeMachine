using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Beverage
{
    class FlatWhite : BeverageBase
    {
        public FlatWhite()
        {
            DESCRIPTION = "Флет Уайт";
        }

        public override double GetCost()
        {
            return 80;
        }
    }
}
