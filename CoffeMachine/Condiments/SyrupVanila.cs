using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Condiments
{
    class SyrupVanila : ConSyrup
    {
        protected static string SYRUP_TYPE = "Ванильный";

        public SyrupVanila()
        {
            DESCRIPTION = "Ванильный";
        }

        public SyrupVanila(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            DESCRIPTION = beverage.GetDescription() + descr + "(" + SYRUP_TYPE + ")";
        }
    }
}
