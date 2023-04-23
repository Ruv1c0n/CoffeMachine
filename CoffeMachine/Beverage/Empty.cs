using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Beverage
{
    class Empty : BeverageBase
    {
        public Empty()
        {
            DESCRIPTION = "Пусто";
        }
        public override double GetCost()
        {
            return 0;
        }
    }
}
