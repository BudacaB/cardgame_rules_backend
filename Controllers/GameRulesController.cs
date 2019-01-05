using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cardgame_rules_backend.Models;
using cardgame_rules_backend.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cardgame_rules_backend
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameRulesController : Controller
    {
        [HttpPost]
        public ActionResult<CompareResult> CompareCards([FromBody] Card[] cards)
        {
            if (cards.Length != 2)
            {
                var response = new CompareResult();
                response.Error = "Need two cards";
                return response;
            }

            //if (cards[0].Number == cards[1].Number)
            //{
            //    var response = new CompareResult();
            //    response.Error = "Need two different cards";
            //    return response;
            //}
            return WarRulesService.CompareCards(cards[0], cards[1]);

        }
    }
}
