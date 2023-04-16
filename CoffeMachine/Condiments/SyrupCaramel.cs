using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    internal class SyrupCaramel : ConSyrup
    {
        protected static string SYRUP_TYPE = "Карамель";

        public SyrupCaramel(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr + "(" + SYRUP_TYPE + ")";
        }

        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }

    }
}
