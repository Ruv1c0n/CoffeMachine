using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    //Интерфейс стратегии выбора
    public interface ISelect
    {
        CCoffeMachine CCoffeMachine { get=>null; set { } }

        public BeverageBase Select(CoffeMachineCapacity capacity, Dictionary<int, BeverageBase> list1, Dictionary<int, BeverageBase> list2 = null, BeverageBase drink = null);
    }
}
