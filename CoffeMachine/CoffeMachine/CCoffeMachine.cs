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
        private int bank;

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
            bank = 10000;
        }
        private void BankUpdate()
        {
            Console.Clear();
            Console.WriteLine("\n\t{0}\n\tПополнить внутренний банк?", bank);
            Console.ReadLine();
            bank = 10000;
        }
        private void TakeBank()
        {
            Console.Clear();
            Console.WriteLine("\n\t{0}\n\tСколько снять?", bank);
            int val = Convert.ToInt32(Console.ReadLine());
            bank = 10000 - val;
        }
        private void UpdateCapacity()
        {
            Console.Clear();
            Console.WriteLine("\n\tПополнение ингридиентов");
            Console.ReadLine();
            capacity = new CoffeMachineCapacity();
            Console.Clear();
            Console.WriteLine("\n\tПополнение ингридиентов успешно завершено");
            Thread.Sleep(1000);
        }
        public void Start()
        {
            Console.Clear();
            if(bank <= 2000)
            {
                Console.WriteLine("\n\tПриносим извинения, аппарат не работает.");
                string pass = Console.ReadLine();
                if (pass == "2789")
                {
                    BankUpdate();
                    Start();
                }
                else
                {
                    Start();
                }
            }
            Console.WriteLine("\n\tДобро пожаловать!\nВыберите желаемый напиток, нажав на подходящую кнопку.\n");
            string pas = Console.ReadLine();
            if(pas == "2789")
            {
                Console.Clear();
                Console.WriteLine("\n\t1 - Снять деньги\n\t2 - Пополнить ингридиенты\nВыйти");
                pas = Console.ReadLine();
                switch (pas)
                {
                    case "1":
                        {
                            TakeBank();
                            Start();
                            break;
                        }
                    case "2":
                        {
                            UpdateCapacity();
                            Start();
                            break;
                        }
                    default:
                        {
                            Start();
                            break;
                        }
                }
            }
            CoffeMachineStrategy = new SelectBeverage();
            SelectBeverage();
        }
        private void SelectBeverage()
        {
            Console.Clear();
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
                    Console.Clear();
                    AddCondiments();
                }
            }
        }

        private void AddCondiments()
        {
            BeverageBase val;
            do
            {
                Console.WriteLine(drink.GetDescription());
                Console.WriteLine("\nВыберите желаемый наполнитель, 0 - если хотите прекратиь выбор.");
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
                    else if (val.GetDescription() != new Condiments.Empty(drink).GetDescription())
                    {
                        drink = val;
                    }
                    else
                    {
                        break;
                    }
                }
            } while (true);
            Process();
        }
        private static void drawTextProgressBar(int progress, int total)
        {
            Console.CursorLeft = 0;
            Console.Write("["); 
            Console.CursorLeft = 32;
            Console.Write("]"); 
            Console.CursorLeft = 1;
            float onechunk = 30.0f / total;

            int position = 1;
            for (int i = 0; i < onechunk * progress; i++)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            for (int i = position; i <= 31; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            Console.CursorLeft = 35;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        private void Process() {
            Console.WriteLine("\n\tНапиток готовится\n");
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                    drawTextProgressBar(i, 100);
                }
            Console.Clear();
            Console.WriteLine("\nВаш напиток: {0}.\nК оплате: {1}", drink.GetDescription(), drink.GetCost());
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
                        bank += Convert.ToInt32(drink.GetCost());
                        Stop(true);
                        break;
                    }
                default:
                    {
                        bank += Convert.ToInt32(drink.GetCost());
                        Stop(true);
                        break;
                    }
            }
        }
        private void Stop(bool isDone)
        {
            Console.Clear();
            if (isDone) 
            {
                Console.WriteLine("Спасибо за покупку! Ждём вас снова!");
            }
            Console.ReadLine();
            Console.Clear();
            Start();
        }
    }
}