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
        private ISelect CoffeMachineSelectStrategy;
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
            CoffeMachineSelectStrategy = new SelectBeverage();
            capacity = new CoffeMachineCapacity();
            drink = new Beverage.Empty();
            bank = 0;
        }

        private void BankUpdate()
        {
            Console.Clear();
            Console.WriteLine("\n\t{0}\n\tПополнить внутренний банк?", bank);
            int val = Convert.ToInt32(Console.ReadLine());
            bank += val;
            Console.Clear();
            Console.WriteLine("\n\tВнутренний банк пополнен на {0}. Всего - {1} рублей", val, bank);
            Thread.Sleep(2000);
        }
        private void TakeBank()
        {
            Console.Clear();
            Console.WriteLine("\n\t{0}\n\tСколько снять?", bank);
            int val = Convert.ToInt32(Console.ReadLine());
            bank -= val;
            Console.WriteLine("\n\tБыло снято {0}, остаток - {1}", val, bank);
            Console.ReadLine();
        }
        private void UpdateCapacity()
        {
            Console.Clear();
            Console.WriteLine("\n\tПополнение ингредиентов");
            Console.ReadLine();
            capacity = new CoffeMachineCapacity();
            Console.Clear();
            Console.WriteLine("\n\tПополнение ингредиентов успешно завершено");
            Thread.Sleep(2000);
        }
        private void CheckBank()
        {
            Console.Clear();
            Console.WriteLine("\n\tВ банке {0} рублей", bank);
            Console.ReadLine();
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
                }       
                
                Start();
            }
            Console.WriteLine("\n\tДобро пожаловать!");
            string pas = Console.ReadLine();
            if(pas == "2789")
            {
                Console.Clear();
                Console.WriteLine("\n\t1 - Снять деньги\n\t2 - Положить деньги\n\t3 - Просмотреть количество денег в банке\n\t4 - Пополнить ингредиенты\nВыйти");
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
                            BankUpdate();
                            Start();
                            break;
                        }
                    case "3":
                        {
                           CheckBank();
                            Start();
                            break;
                        }
                    case "4":
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
            
            CoffeMachineSelectStrategy = new SelectBeverage();
            SelectBeverage();
        }
        private void SelectBeverage()
        {
            Console.Clear();
            Console.WriteLine("\nВыберите желаемый напиток, нажав на подходящую кнопку.");
            drink = CoffeMachineSelectStrategy.Select(capacity, beverageDrink, null, drink);
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
                    CoffeMachineSelectStrategy = new SelectCondiments();
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
                Console.WriteLine("\nВыберите желаемый наполнитель.");
                val = CoffeMachineSelectStrategy.Select(capacity, beverageCondiments, beverageSyrup, drink);
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
        private void Process() {
            Console.Clear();
            Console.WriteLine("\nВаш напиток: {0}.\nК оплате: {1}", drink.GetDescription(), drink.GetCost());
            Console.WriteLine("1 - Отмена\n2 - Оплатить");
            int payment = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (payment)
            {
                case 1:
                    {
                        drink = new Beverage.Empty();
                        Stop(false);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\n\tВнесите деньги");
                        int val = Convert.ToInt32(Console.ReadLine());
                        double cost = drink.GetCost();
                        while (val < cost)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tОшибка! Внесенное количество средст недостаточно для оплаты. Попробуйте снова или отмените заказ.\n0 - Выйти");
                            val = Convert.ToInt32(Console.ReadLine());
                            if (val == 0)
                            {
                                Stop(false);
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("\n\tВнесено - {0}, стоимость - {1}, сдача - {2}", val, cost, val - cost);
                        bank += Convert.ToInt32(cost);
                        Thread.Sleep(2000);
                        Stop(true);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\n\tВнесите деньги");
                        int val = Convert.ToInt32(Console.ReadLine());
                        double cost = drink.GetCost();
                        Console.WriteLine("\n\tВнесено - {0}, стоимость - {1}, сдача - {2}", val, cost, val - cost);
                        bank += Convert.ToInt32(cost);
                        Thread.Sleep(2000);
                        Stop(true);
                        break;
                    }
            }
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
        private void Stop(bool isDone)
        {
            Console.Clear();
            if (isDone) 
            {
                Console.WriteLine("\n\tНапиток готовится\n");
                for (int i = 0; i < Convert.ToInt32(drink.GetCost()); i++)
                {
                    Thread.Sleep(100);
                    drawTextProgressBar(i, Convert.ToInt32(drink.GetCost()));
                }
                Console.Clear();
                Console.WriteLine("\n\tСпасибо за покупку! Ждём вас снова!");
                Console.ReadLine();
            }
           
            Start();
        }
    }
}