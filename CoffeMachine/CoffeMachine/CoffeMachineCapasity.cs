using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    public class CoffeMachineCapacity
    {
        static int water_cap = 1500;
        static int coffee_cap = 500;
        static int milk_cap = 1000;
        static int sugar_cap = 300;
        static int cocoa_cap = 200;
        static int chocolate_cap = 300;
        static int syrop_vanil_cap = 200;
        static int syrop_chocolate_cap = 200;
        static int syrop_caramel_cap = 200;


        public void Espresso()
        {
            water_cap--;
            coffee_cap--;
        }
        public void BoiledWater()
        {
            water_cap--;
        }
        public void Americano()
        {
            water_cap -= 2;
            coffee_cap--;
        }
        public void Cappuccino()
        {
            water_cap--;
            coffee_cap--;
            milk_cap--;
        }
        public void Cocoa()
        {
            milk_cap--;
            cocoa_cap--;
            sugar_cap--;
        }
        public void Doppio()
        {
            water_cap -= 2;
            coffee_cap -= 2;
        }
        public void FlatWhite()
        {
            water_cap--;
            coffee_cap--;
            milk_cap -= 2;
        }
        public void HotChocolate()
        {
            milk_cap--;
            chocolate_cap--;
        }
        public void Latte()
        {
            water_cap--;
            coffee_cap--;
            milk_cap -= 2;
        }
        public void Macciato()
        {
            water_cap -= 2;
            coffee_cap -= 2;
            milk_cap -= 2;
        }
        public void Milk()
        {
            milk_cap--;
        }
        public void Sugar()
        {
            sugar_cap--;
        }
        public void VanillaSyrup()
        {
            syrop_vanil_cap--;
        }
        public void ChocolateSyrup()
        {
            syrop_chocolate_cap--;
        }
        public void CaramelSyrup()
        {
            syrop_caramel_cap--;
        }

        public void Print_ingridients()
        {

            Console.WriteLine("Количество Воды : " , water_cap);
            Console.WriteLine("Количество caхара : " , sugar_cap);
            Console.WriteLine("Количество молока : " , milk_cap);
            Console.WriteLine("Количество какао : ", cocoa_cap);
            Console.WriteLine("Количество шоколада : ",chocolate_cap );
            Console.WriteLine("Количество карамели : " , syrop_caramel_cap);
            Console.WriteLine("Количество шоколадного сиропа : ", syrop_chocolate_cap);
            Console.WriteLine("Количество  ванильного сиропа : ", syrop_vanil_cap);

        }

       
    }
}

