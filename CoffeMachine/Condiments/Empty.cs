using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    class Empty : CondimentsBase
    {
        protected static string TYPE = "Опционально";
        private static double COST = 0;
        private static string descr = "";
        protected string out_description = "Ничего";

        public Empty()
        {
        }

        public override double GetCost()
        {
            return this.beverageBase.GetCost() + COST;
        }
    }
}
