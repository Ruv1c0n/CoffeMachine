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
        protected static string TYPE = "Основа";
        private static double COST = 30;
        private static string DESCRIPTION = " + порция кофе 7гр";
        BeverageBase beverageBase;

        public ConCoffee(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + DESCRIPTION;
        }

        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
    }
}
