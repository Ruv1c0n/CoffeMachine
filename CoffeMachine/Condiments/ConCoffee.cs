using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    class ConCoffee : CondimentsBase
    {
        private static double COST = 30;
        private static string descr = " + порция кофе 7гр";

        public ConCoffee(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr;
        }
        public ConCoffee()
        {
            DESCRIPTION = "Кофе";
        }

        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
        public override double Cost()
        {
            return 30;
        }
    }
}
