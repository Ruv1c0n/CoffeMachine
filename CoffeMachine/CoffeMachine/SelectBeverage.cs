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
        public BeverageBase Select(CoffeMachineCapacity capacity, Dictionary<int, BeverageBase> beverage, Dictionary<int, BeverageBase> list2, BeverageBase drink)
        {
            Console.WriteLine();
            foreach (var bev in beverage)
            {
                Console.WriteLine("\t{0} - {1}, {2}", bev.Key, bev.Value.GetDescription(), bev.Value.GetCost());
            }
            Console.WriteLine("Выйти");
            string drink_num = Console.ReadLine();

            switch (drink_num)
            {
                case "1":
                    {
                        if (capacity.BoiledWater())
                        {
                            return new Beverage.BoiledWater();
                        }
                        else
                        {
                            return new Beverage.Empty();
                        }
                    }
                case "2":
                    {
                        if (capacity.Espresso())
                        {
                            return new Beverage.Espresso();
                        }
                        else
                        {
                            return new Beverage.Empty();
                        }
                    }
                case "3":
                    {
                        if (capacity.Americano())
                        {
                            return new Beverage.Americano();
                        }
                        else
                        {
                            return new Beverage.Empty();
                        }
                    }
                case "4":
                    {
                        if (capacity.Cappuccino())
                        {
                            return new Beverage.Cappuccino();
                        }
                        else
                        {
                            return new Beverage.Empty();
                        }
                    }
                case "5":
                    {
                        if (capacity.Latte())
                        {
                            return new Beverage.Latte();
                        }
                        else
                        {
                            return new Beverage.Empty();
                        }
                    }
                case "6":
                    {
                        if (capacity.HotChocolate())
                        {
                            return new Beverage.HotChocolate();
                        }
                        else
                        {
                            return new Beverage.Empty();
                        }
                    }
                case "7":
                    {
                        if (capacity.Cocoa())
                        {
                            return new Beverage.Cocoa();
                        }
                        else
                        {
                            return new Beverage.Empty();
                        }
                    }
                case "8":
                    {
                        if (capacity.Macciato())
                        {
                            return new Beverage.Macciato();
                        }
                        else
                        {
                            return new Beverage.Empty();
                        }
                    }
                case "9":
                    {
                        if (capacity.Doppio())
                        {
                            return new Beverage.Doppio();
                        }
                        else
                        {
                            return new Beverage.Empty();
                        }
                    }
                case "10":
                    {
                        if (capacity.FlatWhite())
                        {
                            return new Beverage.FlatWhite();
                        }
                        else
                        {
                            return new Beverage.Empty();
                        }
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
