using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    public class CCoffeMachine
    {
        Dictionary<string, int> beverage;
        private IStrategy CoffeMachineStrategy;

        public CCoffeMachine()
        {
            this.beverage = new Dictionary<string, int>()
            {
                {"Горячая вода", 1},
                {"Эспрессо", 2},
                {"Американо", 3},
                {"Каппучино", 4},
                {"Латте", 5},
                {"Горячий шоколад", 6},
                {"Какао", 7},
                {"Маккиато", 8},
                {"Доппио", 9},
                {"Флет Уайт", 10}
            };
        }

        public void Start()
        {
            Console.WriteLine("\n\tДобро пожаловать!\nВыберите желаемый напиток, нажав на подходящую кнопку.\n");
            CoffeMachineStrategy = new SelectBeverage();
            SelectBeverage();
        }
        public void SelectBeverage()
        {
            CoffeMachineStrategy.Select(beverage);
            CoffeMachineStrategy = new SelectCondiments();
        }
        public void AddCondiments() {
            
        }
        public void Process() { }
        public void Stop()
        {
            Console.WriteLine("Спасибо за покупку! Ждём вас снова!");
        }
    }
}
