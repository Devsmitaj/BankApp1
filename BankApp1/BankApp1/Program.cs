using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            //account.AccountNumber=12345;
            account.EmailAddress = "test@tesct.com";
            account.TypeOfAccount = "Checking";
            //account.Balance = 10000;

            Console.WriteLine(account.Balance);
            var account2 = new Account();
            account2.EmailAddress = "test2.test.com";
        }
    }
}
