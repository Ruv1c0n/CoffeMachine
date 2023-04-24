using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    class ConChocolate : CondimentsBase
    {
        private static double COST = 100;
        private static string descr = " + порция шоколада 70гр";

        public ConChocolate(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr;
        }
        public ConChocolate()
        {
            DESCRIPTION = "Шоколад";
        }

        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
        public override double Cost()
        {
            return 100;
        }
    }
}
