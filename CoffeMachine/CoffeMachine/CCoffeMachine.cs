using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeMachine.CoffeMachine;

namespace CoffeMachine.CoffeMachine
{
    public class CCoffeMachine
    {
        Dictionary<string, int> beverageDrink;
        private Dictionary<string, int> beverageCondiments;
        private Dictionary<string, int> beverageSyrup;

        public CCoffeMachine()
        {
            this.beverageDrink = new Dictionary<string, int>()
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


            this.beverageCondiments = new Dictionary<string, int>()
            {
                {"Без наполнителя", 0},
                {"Сироп", 1},
                {"Сахар", 2},
                {"Молоко", 3},
            };

            this.beverageSyrup = new Dictionary<string, int>()
            {
                {"Шоколадный сироп", 1},
                {"Карамельный сироп", 2},
                {"Ванильный сироп", 3},
            };

        }

        public void Start()
        {
            Console.WriteLine("\n\tДобро пожаловать!\nВыберите желаемый напиток, нажав на подходящую кнопку.\n");
            SelectBeverage();
        }
        public void SelectBeverage()
        {
            foreach (var beverage in this.beverageDrink)
            {
                Console.WriteLine("\t{0} - {1}", beverage.Key, beverage.Value);
            }
            int task = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        public void AddCondiments() {
            Console.WriteLine("Выберите желаемый наполнитель: 1 - 5, 0 - если не хотите брать наполнитель");
            SelectCondiments sc = new SelectCondiments();
        }

        public void Process() { }
        public void Stop()
        {
            Console.WriteLine("Спасибо за покупку! Ждём вас снова!");
        }
    }
}
