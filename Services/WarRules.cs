using cardgame_rules_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardgame_rules_backend.Services
{
    public class WarRules
    {
        
        public static int CompareCards(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int CompareCards(Card firstCard, Card secondCard)
        {
            if (firstCard.Value < secondCard.Value)
            {
                return -1;
            }
            else if (firstCard.Value == secondCard.Value)
            {
                return 0;
            }
            return 1;

        }
    }
}
