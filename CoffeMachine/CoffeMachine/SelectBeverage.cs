using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    class SelectBeverage : ISelect
    {
        public BeverageBase Select(CoffeMachineCapacity capacity, Dictionary<int, BeverageBase> beverage, Dictionary<int, BeverageBase> list2)
        {
            foreach (var bev in beverage)
            {
                Console.WriteLine("\t{0} - {1}", bev.Key, bev.Value.GetDescription());
            }
            int drink = Convert.ToInt32(Console.ReadLine());

            switch (drink)
            {
                case 1:
                    {
                        capacity.BoiledWater();
                        return new BoiledWater();
                    }
                case 2:
                    {
                        capacity.Espresso();
                        return new Espresso();
                    }
                case 3:
                    {
                        capacity.Americano();
                        return new Americano();
                    }
                case 4:
                    {
                        capacity.Cappuccino();
                        return new Cappuccino();
                    }
                case 5:
                    {
                        capacity.Latte();
                        return new Latte();
                    }
                case 6:
                    {
                        capacity.HotChocolate();
                        return new HotChocolate();
                    }
                case 7:
                    {
                        capacity.Cocoa();
                        return new Cocoa();
                    }
                case 8:
                    {
                        capacity.Macciato();
                        return new Macciato();
                    }
                case 9:
                    {
                        capacity.FlatWhite();
                        return new FlatWhite();
                    }
                default:
                    {
                        return new BoiledWater();
                    }
            }
        }
    }
}
