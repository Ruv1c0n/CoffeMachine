using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    class ConMilk : CondimentsBase
    {
        protected static string TYPE = "Опционально";
        private static double COST = 10;
        private static string DESCRIPTION = " + молоко 100мл";
        BeverageBase beverageBase;

        public ConMilk(BeverageBase beverage)
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
