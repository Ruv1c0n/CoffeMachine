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
        protected string out_description = "Карамель";

        public SyrupCaramel()
        {
            DESCRIPTION = "Карамельный";
        }

        public SyrupCaramel(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr + "(" + SYRUP_TYPE + ")";
        }

    }
}
