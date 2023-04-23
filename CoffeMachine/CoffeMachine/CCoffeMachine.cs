using CoffeMachine.Beverage;
using CoffeMachine.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    public class CCoffeMachine
    {
        private Dictionary<int, BeverageBase> beverageDrink;
        private Dictionary<int, BeverageBase> beverageCondiments;
        private Dictionary<int, BeverageBase> beverageSyrup;
        private ISelect CoffeMachineStrategy;
        public CoffeMachineCapacity capacity;
        private BeverageBase drink;

        public CCoffeMachine()
        {
            this.beverageDrink = new Dictionary<int, BeverageBase>()
            {
                {1, new Beverage.BoiledWater()},
                {2, new Beverage.Espresso()},
                {3, new Beverage.Americano()},
                {4, new Beverage.Cappuccino()},
                {5, new Beverage.Latte()},
                {6, new Beverage.HotChocolate()},
                {7, new Beverage.Cocoa()},
                {8, new Beverage.Macciato()},
                {9, new Beverage.Doppio()},
                {10, new Beverage.FlatWhite()}
            };

            this.beverageCondiments = new Dictionary<int, BeverageBase>()
            {
                {0, new Condiments.Empty()},
                {1, new Condiments.ConSyrup()},
                {2, new Condiments.ConSugar()},
                {3, new Condiments.ConMilk()},
            };

            this.beverageSyrup = new Dictionary<int, BeverageBase>()
            {
                {1, new Condiments.SyrupChocolate()},
                {2, new Condiments.SyrupCaramel()},
                {3, new Condiments.SyrupVanila()},
            };
            CoffeMachineStrategy = new SelectBeverage();
            capacity = new CoffeMachineCapacity();
            drink = new Beverage.Empty();
        }

        public void Start()
        {
            Console.WriteLine("\n\tДобро пожаловать!\nВыберите желаемый напиток, нажав на подходящую кнопку.");
            Console.ReadLine();
            CoffeMachineStrategy = new SelectBeverage();
            SelectBeverage();
        }
        private void SelectBeverage()
        {

            drink = CoffeMachineStrategy.Select(capacity, beverageDrink, null, drink);
            if (drink == null)
            {
                Console.Clear();
                Start();
            }
            else
            {
                if (drink.GetDescription() == new Beverage.Empty().GetDescription())
                {
                    Console.WriteLine("Извините, в настоящий момент мы не можем приготовить этот напиток.\nПожалуйста, выберите другой или позовите обслуживающий персонал.");
                    Console.ReadLine();
                    Console.Clear();
                    SelectBeverage();
                }
                else
                {
                    CoffeMachineStrategy = new SelectCondiments();
                    AddCondiments();
                }
            }
        }

        private void AddCondiments()
        {
            BeverageBase val;
            do
            {
                Console.WriteLine("Выберите желаемый наполнитель, 0 - если хотите прекратиь выбор.");
                val = CoffeMachineStrategy.Select(capacity, beverageCondiments, beverageSyrup, drink);
                if (val == null)
                {
                    Console.Clear();
                    Start();
                }
                else
                {
                    if (val == drink)
                    {
                        Console.Clear();
                        AddCondiments();
                    }
                    else
                    {
                        drink = val;
                    }
                }
            } while (val.GetDescription() != new Condiments.Empty(drink).GetDescription());
            Process();
        }

        private void Process()
        {
            Console.WriteLine("Ваш напиток: {0}.\nК оплате: {1}", drink.GetDescription(), drink.GetCost());
            Console.WriteLine("Отмена");
            string payment = Console.ReadLine().ToLower();
            switch (payment)
            {
                case "отмена":
                    {
                        drink = new Beverage.Empty();
                        Stop(false);
                        break;
                    }
                case "оплатить":
                    {
                        Stop(true);
                        break;
                    }
                default:
                    {
                        Stop(true);
                        break;
                    }
            }
        }
        private void Stop(bool isDone)
        {
            if (isDone) 
            {
                Console.WriteLine("Спасибо за покупку! Ждём вас снова!");
            }
            Console.Clear();
            Start();
        }
    }
}