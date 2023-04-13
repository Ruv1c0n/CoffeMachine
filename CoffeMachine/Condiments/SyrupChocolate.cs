using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    internal class SyrupChocolate : ConSyrup
    {
        protected static string SYRUP_TYPE = "Шоколадный";

        public SyrupChocolate(BeverageBase beverage)
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
