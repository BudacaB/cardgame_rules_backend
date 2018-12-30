using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardgame_rules_backend.Models
{
    public class Card
    {
        //"suit": "hearts",
        //"number": "2",
        //"id": "2_of_hearts"

        public string Suit { get; set; }
        public int Number { get; set; }
        public string ID { get; set; }

    }
}
