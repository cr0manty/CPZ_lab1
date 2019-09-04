using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPZ_1
{
    class BankBill
    {
        public enum Deposits_type
        {
            MIN = 10,
            AVERAGE = 50,
            PRE_MAX = 70,
            MAX = 100
        }

        private string full_name;
        private string bill_number;
        private List<Deposits_type> deposits;
        private float amount;
        
        private bool is_digit(string _str)
        {
            foreach (var i in _str)
                if (!Char.IsDigit(i))
                    return false;
            return true;
        }

        public BankBill(string _full_name, string _bill_number, float _amount)
        {
            try
            {
                if (_full_name.Length is 0)
                    throw new Exception("Name can't be empty!");
                else if (_bill_number.Length != 8 && is_digit(_bill_number))
                    throw new Exception("Bill number error!");
                else if (_amount <= 0)
                    throw new Exception("Deposit amount cant be negative");

                full_name = _full_name;
                bill_number = _bill_number;
                amount = _amount;
                deposits = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void deposit_money(float _amount)
        {

        }

        public void withdraw(float _amount)
        {

        }
    }
}
