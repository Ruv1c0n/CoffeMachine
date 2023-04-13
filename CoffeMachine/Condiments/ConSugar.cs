using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    class ConSugar : CondimentsBase
    {
        protected static string TYPE = "Опционально";
        private static double COST = 5;
        private static string DESCRIPTION = " + сахар 6гр";
        BeverageBase beverageBase;

        public ConSugar(BeverageBase beverage)
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
