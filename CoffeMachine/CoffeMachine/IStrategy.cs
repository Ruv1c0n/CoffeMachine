using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    public interface IStrategy
    {
        public int Select(Dictionary<BeverageBase, int> list1, Dictionary<BeverageBase, int> list2 = null);
    }
}
