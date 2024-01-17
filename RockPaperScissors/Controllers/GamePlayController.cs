using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;
using System;
using System.Collections.Generic;

namespace RockPaperScissors.Controllers
{
    public class GamePlayController : Controller
    {
        [HttpGet("/indexplaying")]
        public ActionResult Index()
        {
            List<GamePlay> listOfWinners = GamePlay.GetAllGamePlays();
            return View(listOfWinners);
        }
    }
}