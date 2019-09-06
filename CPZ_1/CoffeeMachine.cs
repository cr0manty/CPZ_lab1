using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPZ_1
{
    class CoffeeMachine
    {
        public enum COFFE_TYPES
        {
            CAPPUCINO = 20,
            AMERICANO = 32,
            ESPRESSO = 41,
            LATTE = 58
        }

        private string model_name;
        private double coffee;
        private double milk;
        private double water;
        private double sugar;
        private double cash;

        private const double max_coffee = 500;
        private const double max_milk = 500;
        private const double max_water = 500;
        private const double max_sugar = 500;

        public string ModelName
        {
            get { return model_name; }
            set
            {
                if (value.Length == 0 || !is_space(value))
                    throw new Exception("Value can't be empty and can't consist any spaces");
                model_name = value;
            }
        }
        public double Coffee 
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Value must be more than 0!");
                else if (coffee + value > max_coffee)
                    throw new Exception("Value more than max!");
                coffee += value;
                Console.WriteLine("Coffee stock updated successfully!");
            }
        }
        public double Milk
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Value must be more than 0!");
                else if (milk + value > max_milk)
                    throw new Exception("Value more than max!");
                milk += value;
                Console.WriteLine("Milk stock updated successfully!");

            }
        }
        public double Water
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Value must be more than 0!");
                else if (water + value > max_water)
                    throw new Exception("Value more than max!");
                water += value;
                Console.WriteLine("Water stock updated successfully!");

            }
        }
        public double Sugar
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Value must be more than 0!");
                else if (sugar + value > max_sugar)
                    throw new Exception("Value more than max!");
                sugar += value;
                Console.WriteLine("Sugar stock updated successfully!");

            }
        }
        public double Cash
        {
            get { return cash; }
        }


        private void take_from_bank(ref double var, string _name, double _amount)
        {
            if (var - _amount < 0)
                throw new Exception("Not enought " + _name + "!");
            var -= _amount;
        }

        private bool is_space(string _str)
        {
            foreach (var i in _str)
                if (i == ' ')
                    return false;
            return true;

        }

        public CoffeeMachine(string _model_name)
        {
            ModelName = _model_name;
            this.cash = 0;

            this.coffee = max_coffee;
            this.milk = max_milk;
            this.water = max_water;
            this.sugar = max_sugar;
        }
        
        public void make_cup(COFFE_TYPES _type, double _money)
        {
            int value = (int)_type;

            if ((int)_type >= _money)
                throw new Exception("Not enough money!");

            this.cash += _money;
            this.take_from_bank(ref this.coffee, "Coffee", value - 3);
            this.take_from_bank(ref this.milk, "Miilk", value + 7);
            this.take_from_bank(ref this.water, "Water", value + 10);
            this.take_from_bank(ref this.sugar, "Sugar" , value - 15);
            Console.WriteLine("Your coffee is ready");
        }

        public void make_cups(COFFE_TYPES[] _coffe, double _money)
        {
            double price = 0;
            foreach (int i in _coffe)
                price += i;

            if (price >= _money)
                throw new Exception("Not enough money for all coffe!");

            foreach (COFFE_TYPES i in _coffe)
                this.make_cup(i, _money / _coffe.Length);
        }

    }
}
