using CoffeMachine.Beverage;
using CoffeMachine.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    class SelectCondiments: ISelect
    {
        public BeverageBase Select(CoffeMachineCapacity capacity, Dictionary<int, BeverageBase> condiments, Dictionary<int, BeverageBase> syrup=null)
        {

            foreach (var bev in condiments)
            {
                Console.WriteLine("\t{0} - {1}", bev.Key, bev.Value.GetDescription());
            }

            int condiment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); 

            if (condiment == 1)
            {
                foreach (var bev in syrup)
                {
                    Console.WriteLine("\t{0} - {1}", bev.Key, bev.Value.GetDescription());
                }
                condiment = Convert.ToInt32(Console.ReadLine());

                switch (condiment)
                {
                    case 1:
                        {
                            capacity.ChocolateSyrup();
                            return new Condiments.SyrupChocolate();
                        }
                    case 2:
                        {
                            capacity.CaramelSyrup();
                            return new Condiments.SyrupCaramel();
                        }
                    case 3:
                        {
                            capacity.VanillaSyrup();
                            return new Condiments.SyrupVanila();
                        }
                    default:
                        {
                            return new Condiments.Empty();
                        }
                }
            }
            else
            {
                switch (condiment)
                {
                    case 2:
                        {
                            capacity.Sugar();
                            return new Condiments.ConSugar();
                        }
                    case 3:
                        {
                            capacity.Milk();
                            return new Condiments.ConMilk();
                        }
                    default:
                        {
                            return new Condiments.Empty();
                        }
                }
            }
        }
    }
}
