using CoffeMachine.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    class SelectBeverage : IStrategy
    {
        public int Select(Dictionary<BeverageBase, int> Beverage, Dictionary<BeverageBase, int> list2)
        {
            foreach (var bev in beverage)
            {
                Console.WriteLine("\t{0} - {1}", bev.Key.GetDescription(), bev.Value);
            }
            int drink = Convert.ToInt32(Console.ReadLine());

            switch (drink)
            {
                case 1:
                    {
                        capacity.BoiledWater();
                        break;
                    }
                case 2:
                    {
                        capacity.Espresso();
                        break;
                    }
                case 3:
                    {
                        capacity.Americano();
                        break;
                    }
                case 4:
                    {
                        capacity.Cappuccino();
                        break;
                    }
                case 5:
                    {
                        capacity.Latte();
                        break;
                    }
                case 6:
                    {
                        capacity.HotChocolate();
                        break;
                    }
                case 7:
                    {
                        capacity.Cocoa();
                        break;
                    }
                case 8:
                    {
                        capacity.Macciato();
                        break;
                    }
                case 9:
                    {
                        capacity.FlatWhite();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            Console.WriteLine();
            return drink;
        }
    }
}
