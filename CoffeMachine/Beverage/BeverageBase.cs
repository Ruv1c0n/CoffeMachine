using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.Beverage
{
    public abstract class BeverageBase
    {
        protected string DESCRIPTION;
        public string GetDescription()
        {
            return DESCRIPTION;
        }

        public abstract double GetCost();
    }
}
