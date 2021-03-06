using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {   //Properties
        private static int NextAccountNumber { get; set; } = 1;
        public decimal Balance { get; set; }
        public int AccountNumber { get; set; }
        public string Description { get; set; }

        //Methods (actions of the Properties)
        public bool Deposit(decimal Amount)
        {
            if(Amount <= 0) 
            { 
                throw new Exception("Amount must be positive.");
            }
            Balance += Amount;
            return true;
        }
        public bool Withdrawl(decimal Amount)
        {
            if (Amount <= 0)
            {
                throw new Exception("Amount must be positive.");
            }
            if (Amount > Balance)
            {
                throw new Exception("Insufficient Funds!");
            }
            Balance -= Amount;
            return true;
        }
        public bool Transfer(decimal Amount, Account ToAccount)
        {
            try
            {
                Withdrawl(Amount);
            }
            catch (Exception)
            {
                throw new Exception("Witdrawl Fain in Transfer");
            }
            ToAccount.Deposit(Amount);
            return true;
            
        }
        public void Debug()
        {
            Console.WriteLine($"{AccountNumber}|{Description}|{Balance:c}");
        }
        // Constructors
        public Account()  //the name of the contructor is ALWAYS the name of the class with no parens
        {
            AccountNumber = NextAccountNumber;
            NextAccountNumber++;
            Description = "New Account";
            Balance = 0;
        }   
    }
}
