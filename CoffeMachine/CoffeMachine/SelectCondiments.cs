﻿using CoffeMachine.Beverage;
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
        public BeverageBase Select(CoffeMachineCapacity capacity, Dictionary<int, BeverageBase> condiments, Dictionary<int, BeverageBase> syrup, BeverageBase drink)
        {

            foreach (var bev in condiments)
            {
                Console.WriteLine("\t{0} - {1}", bev.Key, bev.Value.GetDescription());
            }
            Console.WriteLine("Выйти");

            string condiment = Console.ReadLine();
            Console.WriteLine(); 

            if (condiment == "1")
            {
                foreach (var bev in syrup)
                {
                    Console.WriteLine("\t{0} - {1}", bev.Key, bev.Value.GetDescription());
                }
                Console.WriteLine("Назад");
                condiment = Console.ReadLine().ToLower();

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
