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
        private Dictionary<BeverageBase, int> beverageDrink;
        private Dictionary<BeverageBase, int> beverageCondiments;
        private Dictionary<BeverageBase, int> beverageSyrup;
        private IStrategy CoffeMachineStrategy;

        public CCoffeMachine()
        {
            this.beverageDrink = new Dictionary<BeverageBase, int>()
            {
                {new Beverage.BoiledWater(), 1},
                {new Beverage.Espresso(), 2},
                {new Beverage.Americano(), 3},
                {new Beverage.Cappuccino(), 4},
                {new Beverage.Latte(), 5},
                {new Beverage.HotChocolate(), 6},
                {new Beverage.Cocoa(), 7},
                {new Beverage.Macciato(), 8},
                {new Beverage.Doppio(), 9},
                {new Beverage.FlatWhite(), 10}
            };


            this.beverageCondiments = new Dictionary<BeverageBase, int>()
            {
                {new Condiments.Empty(), 0},
                {new Condiments.ConSyrup(), 1},
                {new Condiments.ConSugar(), 2},
                {new Condiments.ConMilk(), 3},
            };

            this.beverageSyrup = new Dictionary<BeverageBase, int>()
            {
                {new Condiments.SyrupChocolate(), 1},
                {new Condiments.SyrupCaramel(), 2},
                {new Condiments.SyrupVanila(), 3},
            };
            CoffeMachineStrategy = new SelectBeverage();
        }

        public void Start()
        {
            Console.WriteLine("\n\tДобро пожаловать!\nВыберите желаемый напиток, нажав на подходящую кнопку.\n");
            CoffeMachineStrategy = new SelectBeverage();
            SelectBeverage();
        }
        public void SelectBeverage()
        {
            CoffeMachineStrategy.Select(beverageDrink);
            CoffeMachineStrategy = new SelectCondiments();
            AddCondiments();
        }

        public void AddCondiments() {
            Console.WriteLine("Выберите желаемый наполнитель: 1 - 5, 0 - если не хотите брать наполнитель");
            CoffeMachineStrategy.Select(beverageCondiments, beverageSyrup);
        }

        public void Process() { }
        public void Stop()
        {
            Console.WriteLine("Спасибо за покупку! Ждём вас снова!");
        }
    }
}
