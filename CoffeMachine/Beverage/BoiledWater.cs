using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Beverage
{
    class BoiledWater : BeverageBase
    {
        public BoiledWater()
        {
            DESCRIPTION = "Горячая вода";
        }
        public override double GetCost()
        {
            return 10;
        }
        public override double Cost()
        {
            return 10;
        }
    }
}
