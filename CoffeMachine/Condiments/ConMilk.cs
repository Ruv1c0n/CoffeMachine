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
        private static double COST = 20;
        private static string descr = " + молоко 100мл";
        protected string out_description = "Молоко";

        public ConMilk(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr;
        }

        public ConMilk()
        {
            DESCRIPTION = "Молоко";
        }

        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
    }
}
