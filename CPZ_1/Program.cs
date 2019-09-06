using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPZ_1
{
    class Program
    { 
        private static CoffeeMachine.COFFE_TYPES[] make_array()
        {
            List<CoffeeMachine.COFFE_TYPES> coffe_type = 
                new List<CoffeeMachine.COFFE_TYPES>();

            coffe_type.Add(CoffeeMachine.COFFE_TYPES.CAPPUCINO);
            coffe_type.Add(CoffeeMachine.COFFE_TYPES.AMERICANO);
            coffe_type.Add(CoffeeMachine.COFFE_TYPES.ESPRESSO);
            coffe_type.Add(CoffeeMachine.COFFE_TYPES.LATTE);
            coffe_type.Add(CoffeeMachine.COFFE_TYPES.AMERICANO);
            coffe_type.Add(CoffeeMachine.COFFE_TYPES.CAPPUCINO);
            coffe_type.Add(CoffeeMachine.COFFE_TYPES.LATTE);
            coffe_type.Add(CoffeeMachine.COFFE_TYPES.AMERICANO);
            coffe_type.Add(CoffeeMachine.COFFE_TYPES.CAPPUCINO);
            coffe_type.Add(CoffeeMachine.COFFE_TYPES.ESPRESSO);


            return coffe_type.ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter machine name:");
            string name = Console.ReadLine();
            Console.Clear();
            try
            {
                CoffeeMachine machine = new CoffeeMachine(name);

                Console.WriteLine("Machine name: " + machine.ModelName);
                Console.WriteLine("______________________________");
                Console.WriteLine("Try to make 1 coffee");
                Console.WriteLine("..............................");
                machine.make_cup(CoffeeMachine.COFFE_TYPES.AMERICANO, 50);
                Console.WriteLine("______________________________");

                Console.WriteLine("Trt to make array coffee");
                Console.WriteLine("..............................");
                machine.make_cups(make_array(), 1000);
                Console.WriteLine("______________________________");

                Console.WriteLine("Refill Coffee/Water/Milk/Sugar");
                Console.WriteLine("..............................");
                machine.Coffee = 40;
                machine.Water = 20;
                machine.Milk = 50;
                machine.Sugar = 10;
                Console.WriteLine("______________________________");

                Console.WriteLine("Machine cash");
                Console.WriteLine("..............................");
                Console.WriteLine(machine.Cash);
                Console.WriteLine("______________________________");

                Console.WriteLine("Error: Not enought...");
                Console.WriteLine("..............................");
                machine.make_cup(CoffeeMachine.COFFE_TYPES.AMERICANO, 50);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Read();
        }
    }
}
