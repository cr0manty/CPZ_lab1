using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPZ_1
{
    class Program
    {
        static BankBill input()
        {
            string full_name;
            string bill_number;
            float amount;

            Console.WriteLine("Enter full name:");
            full_name = Console.ReadLine();
            Console.WriteLine("Enter biill number(8 digits):");
            bill_number = Console.ReadLine();
            Console.WriteLine("Enter the amount in the bill:");
            amount = Console.Read();

            return new BankBill(full_name, bill_number, amount);
        }

        static void Main(string[] args)
        {
            BankBill bill = input();

            Console.Read();
        }
    }
}
