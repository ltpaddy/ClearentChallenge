using System;
using System.Collections.Generic;

namespace ClearentChallenge
{
    public class Person : IInterestCalc     {         public List<Wallet> Wallets;

        public decimal CalculateInterest()         {             decimal totalInterest = 0m;             foreach (var wallet in Wallets)             {                 totalInterest += wallet.CalculateInterest();             }             return totalInterest;         }     }
}
