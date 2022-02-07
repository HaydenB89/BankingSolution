using Banking;

using System;

namespace BankingProject
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Account acct1 = new Account();
            acct1.Deposit(500);
            acct1.Withdrawl(200);
            acct1.Debug();
            acct1.Withdrawl(600);
            acct1.Debug();
        }
    }
}
