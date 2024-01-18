using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;
using System;
using System.Collections.Generic;

namespace RockPaperScissors.Controllers
{
    public class GamePlayController : Controller
    {
        // For the game Mode: Single Player
        [HttpGet("/gameplay")]
        public ActionResult Index()
        {
            List<GamePlay> listOfWinners = GamePlay.GetAllGamePlays();
            return View(listOfWinners);
        }

        // For the game Mode: Multiplayer and Single Player
        [HttpGet("/gameplay/newsingle")]
        public ActionResult Singleplayer(string myPlayer1)
        {
            // I am only taking in one vale from here; which is users value
            // Now I have to get the random game value my computer returns so I can pass both in here and determinw who is the winner

            string newCompVal = GamePlay.GetComputerVal();

            GamePlay newGame = new GamePlay(myPlayer1, newCompVal);

            return RedirectToAction("Index");
        }
        [HttpGet("/gameplay/newmulti")]
        public ActionResult Multiplayer(string myPlayer1, string myPlayer2)
        {

            GamePlay newGame = new GamePlay(myPlayer1, myPlayer2);

            string determiningWinner = newGame.DetermineWinner(myPlayer1, myPlayer2);

            // Doing the Multiplayer first to see if it actually works

            return RedirectToAction("Index");
        }
    }
}