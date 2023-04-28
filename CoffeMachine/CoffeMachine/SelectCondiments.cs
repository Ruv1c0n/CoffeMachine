using CoffeMachine.Beverage;
using CoffeMachine.Condiments;

namespace CoffeMachine.CoffeMachine
{
    //Выбор добавки
    class SelectCondiments: ISelect
    {
        ISelect ISelect { get => null; set { } }

        public BeverageBase Select(CoffeMachineCapacity capacity, Dictionary<int, BeverageBase> condiments, Dictionary<int, BeverageBase> syrup, BeverageBase drink)
        {

            foreach (var bev in condiments)
            {
                Console.WriteLine("\t{0} - {1}, {2}", bev.Key, bev.Value.GetDescription(), bev.Value.Cost());
            }
            Console.WriteLine("Выйти");

            string condiment = Console.ReadLine();
            Console.Clear(); 

            if (condiment == "1")
            {
                foreach (var bev in syrup)
                {
                    Console.WriteLine("\t{0} - {1}", bev.Key, bev.Value.GetDescription());
                }
                Console.WriteLine("Назад");
                condiment = Console.ReadLine().ToLower();
                Console.Clear();

                switch (condiment)
                {
                    case "1":
                        {
                            if (capacity.ChocolateSyrup())
                            {
                                return new Condiments.SyrupChocolate(drink);
                            }
                            else
                            {
                                Console.WriteLine("Сироп закончился.\nПожалуйста, выберите что-то другое или позовите обслуживающий персонал. ");
                                return drink;
                            }
                        }
                    case "2":
                        {
                            if (capacity.CaramelSyrup())
                            {
                                return new Condiments.SyrupCaramel(drink);
                            }
                            else
                            {
                                Console.WriteLine("Сироп закончился.\nПожалуйста, выберите что-то другое или позовите обслуживающий персонал. ");
                                return drink;
                            }
                        }
                    case "3":
                        {
                            if (capacity.VanillaSyrup())
                            {
                                return new Condiments.SyrupVanila(drink);
                            }
                            else
                            {
                                Console.WriteLine("Сироп закончился.\nПожалуйста, выберите что-то другое или позовите обслуживающий персонал. ");
                                return drink;
                            }
                        }
                    case "назад":
                        {
                            return drink;
                        }
                    default:
                        {
                            return null;
                        }
                }
            }
            else
            {
                switch (condiment)
                {
                    case "0":
                        {
                            return new Condiments.Empty(drink);
                        }
                    case "2":
                        {
                            if (capacity.Sugar())
                            {
                                return new Condiments.ConSugar(drink);
                            }
                            else
                            {
                                Console.WriteLine("Сахар закончился.\nПожалуйста, выберите что-то другое или позовите обслуживающий персонал. ");
                                return drink;
                            }
                        }
                    case "3":
                        {
                            if (capacity.Milk())
                            {
                                return new Condiments.ConMilk(drink);
                            }
                            else
                            {
                                Console.WriteLine("Молоко закончилось.\nПожалуйста, выберите что-то другое или позовите обслуживающий персонал. ");
                                return drink;
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
}
