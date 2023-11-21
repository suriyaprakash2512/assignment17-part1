using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("surya");

            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            Console.WriteLine($"Account Holder: {myAccount.AccountHolderName}");
            Console.WriteLine($"Initial Balance: {myAccount.Balance}");

            myAccount.Deposit(10000);
            myAccount.Withdraw(6700);

            Console.WriteLine($"Final Balance: ${myAccount.Balance}");
            Console.ReadKey();

        }
    }
}
