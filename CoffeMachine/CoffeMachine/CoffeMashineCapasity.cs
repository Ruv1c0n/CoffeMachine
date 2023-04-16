using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine.CoffeMachine
{
    public class CoffeMashineCapasity
    {

        int water_mass = 1500;
        int coffee_mass = 500;
        int Milk_mass = 1000;
        int Sugar_mass = 300;
        int cacao_mass = 200;
        int chocolate_mass = 300;
        int syrop_vanil_mass = 200;
        int syrop_chocolate_mass = 200;
        int syrop_caramel_mass = 200;


        public int Water()
        {
            water_mass = water_mass - 100;
           return water_mass;
        }
        public int Coffee()
        {
            coffee_mass -=  7 ;
            return coffee_mass;
        }
        public int Sugar()
        {
            Sugar_mass -= 6;
            return Sugar_mass;
        }
        public int Cacao()
        {
            cacao_mass -= 7;
            return cacao_mass;
        }
        public int Milk()
        {
            Milk_mass -= 100;
            return Milk_mass;
        }
        public int Chocolate()
        {
            chocolate_mass -= 70;
            return chocolate_mass;
        }
        public int SyropVanil()
        {
            syrop_vanil_mass -=  10;
            return syrop_vanil_mass;
        }
        public int SyropChocolate()
        {
            syrop_chocolate_mass -=  10;
            return syrop_chocolate_mass;
        }
        public int Karamel()
        {
            syrop_caramel_mass -= 10;
            return syrop_caramel_mass;
        }

        public int Ingridient()
        {
           return  water_mass = 1500;
           return  coffee_mass = 500;
           return  Milk_mass = 1000;
           return  Sugar_mass = 300;
           return  cacao_mass = 200;
           return  chocolate_mass = 300;
           return  syrop_vanil_mass = 200;
           return  syrop_chocolate_mass = 200;
           return  syrop_caramel_mass = 200;
        }
        public void Print_ingridients()
        {

            Console.WriteLine("Количество Воды : " , water_mass);
            Console.WriteLine("Количество caхара : " , Sugar_mass);
            Console.WriteLine("Количество молока : " , Milk_mass);
            Console.WriteLine("Количество какао : ", cacao_mass);
            Console.WriteLine("Количество шоколада : ",chocolate_mass );
            Console.WriteLine("Количество карамели : " , syrop_caramel_mass);
            Console.WriteLine("Количество шоколадного сиропа : ", syrop_chocolate_mass);
            Console.WriteLine("Количество  ванильного сиропа : ", syrop_vanil_mass);

        }

       
    }
}

