using System;
using System.Collections.Generic;

namespace RockPaperScissors.Models
{
    public class GamePlay
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }

        private static List<GamePlay> _gameRecord = new List<GamePlay>(){};
        
        
        
        
            public GamePlay(string myPlayer1, string myPlayer2)
            {   
                Player1 = myPlayer1;
                Player2 = myPlayer2;
                _gameRecord.Add(this);
            }

            public string DetermineWinner(string newPlayer1, string newPlayer2)
            {
                if ((newPlayer1 == "rock") && (newPlayer2 == "scissors"))
                {
                    return "Player 1";
                    
                }
                else if ((newPlayer1 == "rock") && (newPlayer2 == "paper"))
                {
                    return "Player 2";
                    
                }
                else if ((newPlayer1 == "rock") && (newPlayer2 == "rock"))
                {
                    return "NO WINNER!, You both chosed rock";
                    
                }
                else if ((newPlayer1 == "paper") && (newPlayer2 == "rock"))
                {
                    return "Player 1";
                    
                }
                else if ((newPlayer1 == "paper") && (newPlayer2 == "scissors"))
                {
                    return "Player 2";

                }
                else if ((newPlayer1 == "paper") && (newPlayer2 == "paper"))
                {
                    return "NO WINNER, You both chosed paper";

                }
                else if ((newPlayer1 == "scissors") && (newPlayer2 == "paper"))
                {
                    return "Player 1";

                }
                else if ((newPlayer1 == "scissors") && (newPlayer2 == "rock"))
                {
                    return "Player 2";

                }
                else if ((newPlayer1 == "scissors") && (newPlayer2 == "scissors"))
                {
                    return "NO WINNER!, You both chosed scissors";

                }
                else
                {
                    return "NO ONE WINS, YOUR GAME INPUT WAS WRONG, only enter rock, paper, or scissors to see winner";
                }
            }

            public static List<GamePlay> GetAllGamePlays()
            {
                return _gameRecord;
            }

            public static void ClearAllGamePlays()
            {
                _gameRecord.Clear();
            }
    }    
}