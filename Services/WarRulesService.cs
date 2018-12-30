using cardgame_rules_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardgame_rules_backend.Services
{
    public class WarRulesService
    {
        

        public static CompareResult CompareCards(Card firstCard, Card secondCard)
        {
            //"suit": "hearts",
            //"number": "2",
            //"id": "2_of_hearts"

            //if (firstCard.Value < secondCard.Value)
            //{
            //    return -1;
            //}
            //else if (firstCard.Value == secondCard.Value)
            //{
            //    return 0;
            //}
            //return 1;
            var response = new CompareResult();
            response.Reason = "test";
            return response;
        }
    }
}
