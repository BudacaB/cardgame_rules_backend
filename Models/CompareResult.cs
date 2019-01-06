using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardgame_rules_backend.Models
{
    public class CompareResult
    {
        public string Error { get; set; }

        public Card WinnerCard { get; set; }
        public string Reason { get; set; }

        public CompareResult()
        {
              
        }
    }
}
