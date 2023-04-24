using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    //Хранилище ингредиентов
    public class CoffeMachineCapacity
    {
        //Содержание продуктов в шт
        static int water_cap = 1000;
        static int coffee_cap = 500;
        static int milk_cap = 1000;
        static int sugar_cap = 300;
        static int cocoa_cap = 200;
        static int chocolate_cap = 300;
        static int syrop_vanil_cap = 200;
        static int syrop_chocolate_cap = 200;
        static int syrop_caramel_cap = 200;

        private bool isPossible(int val, int count = 1)
        {
            return val >= count;
        }
        public bool Espresso()
        {
            if (isPossible(coffee_cap) && isPossible(water_cap))
            {
                water_cap--;
                coffee_cap--;
                return true;
            }
            return false;
        }
        public bool BoiledWater()
        {
            if (isPossible(water_cap)){
                water_cap--;
                return true;
            }
            return false;
        }
        public bool Americano()
        {

            if (isPossible(coffee_cap) && isPossible(water_cap, 2))
            {
                water_cap-=2;
                coffee_cap--;
                return true;
            }
            return false;
        }
        public bool Cappuccino()
        {
            if (isPossible(coffee_cap) && isPossible(water_cap) && isPossible(milk_cap))
            {
                water_cap--;
                coffee_cap--;
                milk_cap--;
                return true;
            }
            return false;
        }
        public bool Cocoa()
        {
            if (isPossible(cocoa_cap) && isPossible(milk_cap) && isPossible(sugar_cap))
            {
                milk_cap--;
                cocoa_cap--;
                sugar_cap--;
                return true;
            }
            return false;
        }
        public bool Doppio()
        {
            if (isPossible(coffee_cap, 2) && isPossible(water_cap, 2))
            {
                water_cap-=2;
                coffee_cap-=2;
                return true;
            }
            return false;
        }
        public bool FlatWhite()
        {
            if (isPossible(coffee_cap) && isPossible(water_cap) && isPossible(milk_cap, 2))
            {
                water_cap--;
                coffee_cap--;
                milk_cap-=2;
                return true;
            }
            return false;
        }
        public bool HotChocolate()
        {
            if (isPossible(milk_cap) && isPossible(chocolate_cap))
            {
                milk_cap--;
                chocolate_cap--;
                return true;
            }
            return false;
        }
        public bool Latte()
        {
            if (isPossible(coffee_cap) && isPossible(water_cap) && isPossible(milk_cap, 2))
            {
                water_cap--;
                coffee_cap--;
                milk_cap -= 2;
                return true;
            }
            return false;
        }
        public bool Macciato()
        {
            if (isPossible(coffee_cap, 2) && isPossible(water_cap, 2) && isPossible(milk_cap, 2))
            {
                water_cap-=2;
                coffee_cap-=2;
                milk_cap-=2;
                return true;
            }
            return false;
        }
        public bool Milk()
        {
            if (isPossible(milk_cap))
            {
                milk_cap--;
                return true;
            }
            return false;
        }
        public bool Sugar()
        {

            if (isPossible(sugar_cap))
            {
                sugar_cap--;
                return true;
            }
            return false;
        }
        public bool VanillaSyrup()
        {
            if (isPossible(syrop_vanil_cap)) {
                syrop_vanil_cap--;
                return true;
            }
            return false;
        }
        public bool ChocolateSyrup()
        {
            if (isPossible(syrop_chocolate_cap))
            {
                syrop_chocolate_cap--;
                return true;
            }
            return false;
        }
        public bool CaramelSyrup()
        {
            if (isPossible(syrop_caramel_cap))
            {
                syrop_caramel_cap--;
                return true;
            }
            return false;
        }

        public void print_ingridients()
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

