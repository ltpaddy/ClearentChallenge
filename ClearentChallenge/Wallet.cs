using System;
using System.Collections.Generic;

namespace ClearentChallenge
{
    
    public class Wallet : IInterestCalc
    {
        public List<Card> Cards;

        public decimal CalculateInterest()
        {
            decimal totalInterest = 0m;
            foreach (var card in Cards)
            {
                totalInterest += card.CalculateInterest();
            }
            return totalInterest;
        }
    }
}
