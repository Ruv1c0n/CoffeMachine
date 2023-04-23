using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    public interface ISelect
    {
        public BeverageBase Select(CoffeMachineCapacity capacity, Dictionary<int, BeverageBase> list1, Dictionary<int, BeverageBase> list2 = null);
    }
}
