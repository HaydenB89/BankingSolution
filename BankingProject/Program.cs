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
            acct1.Debug();
        }
    }
}
