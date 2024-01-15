using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
    [TestClass]
    public class RockPaperScissorsTests : IDisposable
    {
        // The Dispose() method that we need to implement immediately we make use of our IDisposable interface
        public void Dispose()
        {
            GamePlay.ClearAllGamePlays();
        }
        // First Test: Test to create instance of my GamePlay constructor
        [TestMethod]
        public void RockPaperScissors_CreatesInstanceOfConstructor_RockPaperScissors()
        {
            GamePlay myGame = new GamePlay("Paper", "Scissors");
            Assert.AreEqual(typeof(GamePlay), myGame.GetType());
        }

        // Test to get the game value of Player 
        [TestMethod]
        public void GetPlayer1_ReturnsValueOfPlayer1_String()
        {
            // Arrange
            GamePlay myGame = new GamePlay("Rock", "Scissors");
            string expectedPlayer1Value = "Rock";

            // Act
            string returnedPlayer1Value = myGame.Player1;

            // Assert
            Assert.AreEqual(expectedPlayer1Value, returnedPlayer1Value);

        }

        // 3rd Test: Test to set the game value for Player1
        [TestMethod]
        public void SetPlayer1_SetsValueForPlayer1_Void()
        {
            // Arrange
            GamePlay myGame = new GamePlay("Rock", "Scissors");
            string newPlayer1Val = "Scissors";

            // Act
            myGame.Player1 = newPlayer1Val;

            // Assert
            Assert.AreEqual(newPlayer1Val, myGame.Player1);
        }

        // 4th Test: Test to get the game value for Player1
        [TestMethod]
        public void GetPlayer2_ReturnsValueOfPlayer2_String()
        {
            // Arrange
            GamePlay myGame = new GamePlay("Rock", "Paper");
            string expectedPlayer2Value = "Paper";

            // Act
            string returnedPlayer2Value = myGame.Player2;

            // Assert
            Assert.AreEqual(expectedPlayer2Value, returnedPlayer2Value);
        }

        // 5th Test: Test to set the game value for Player1
        [TestMethod]
        public void SetPlayer2_SetsValueForPlayer2_Void()
        {
            // Arrange
            GamePlay myGame = new GamePlay("Rock", "Scissors");
            string newPlayer2Val = "Scissors";

            // Act
            myGame.Player2 = newPlayer2Val;

            // Assert
            Assert.AreEqual(newPlayer2Val, myGame.Player2);
        }

        // 6th Test: Test Method DetermineWinner(); works at all
        [TestMethod]
        public void DetermineWinner_ReturnsWinner_String()
        {
            // Arrange
            string Player1Val = "rock";
            string Player2Val = "scissors";
            GamePlay myGame = new GamePlay(Player1Val, Player2Val);
            string expectedWinner = "Player 1";

            // Act
            string returnedWinner = myGame.DetermineWinner(Player1Val, Player2Val);

            // Assert
            Assert.AreEqual(expectedWinner, returnedWinner);
        }

         // 7th Test: Test Method DetermineWinner(); first path Player1-rock, Player2-scissors
        [TestMethod]
        public void DetermineWinner_FirstPathOfMethod_String()
        {
            // Arrange
            string Player1Val = "rock";
            string Player2Val = "scissors";
            GamePlay myGame = new GamePlay(Player1Val, Player2Val);
            string expectedWinner = "Player 1";

            // Act
            string returnedWinner = myGame.DetermineWinner(Player1Val, Player2Val);

            // Assert
            Assert.AreEqual(expectedWinner, returnedWinner);
        }

         // 8th Test: Test Method DetermineWinner(); second path:  Player1-rock, Player2-paper
        [TestMethod]
        public void DetermineWinner_SecondPathOfMethod_String()
        {
            // Arrange
            string Player1Val = "rock";
            string Player2Val = "paper";
            GamePlay myGame = new GamePlay(Player1Val, Player2Val);
            string expectedWinner = "Player 2";

            // Act
            string returnedWinner = myGame.DetermineWinner(Player1Val, Player2Val);

            // Assert
            Assert.AreEqual(expectedWinner, returnedWinner);
        }
         
         // 9th Test: Test Method DetermineWinner(); Third path: Player1-rock, Player2-rock
        [TestMethod]
        public void DetermineWinner_ThirdPathOfMethod_String()
        {
            // Arrange
            string Player1Val = "rock";
            string Player2Val = "rock";
            GamePlay myGame = new GamePlay(Player1Val, Player2Val);
            string expectedWinner = "NO WINNER!, You both chosed rock";

            // Act
            string returnedWinner = myGame.DetermineWinner(Player1Val, Player2Val);

            // Assert
            Assert.AreEqual(expectedWinner, returnedWinner);
        }
        
         // 10th Test: Test Method DetermineWinner(); Fourth path: Player1-paper, Player2-rock
        [TestMethod]
        public void DetermineWinner_FourthPathOfMethod_String()
        {
            // Arrange
            string Player1Val = "paper";
            string Player2Val = "rock";
            GamePlay myGame = new GamePlay(Player1Val, Player2Val);
            string expectedWinner = "Player 1";

            // Act
            string returnedWinner = myGame.DetermineWinner(Player1Val, Player2Val);

            // Assert
            Assert.AreEqual(expectedWinner, returnedWinner);
        }
        
         // 11th Test: Test Method DetermineWinner(); Fifth path: Player1-paper, Player2-scissors
        [TestMethod]
        public void DetermineWinner_FifthPathOfMethod_String()
        {
            // Arrange
            string Player1Val = "paper";
            string Player2Val = "scissors";
            GamePlay myGame = new GamePlay(Player1Val, Player2Val);
            string expectedWinner = "Player 2";

            // Act
            string returnedWinner = myGame.DetermineWinner(Player1Val, Player2Val);

            // Assert
            Assert.AreEqual(expectedWinner, returnedWinner);
        }
        
         // 12th Test: Test Method DetermineWinner(); Sixth path: Player1-paper, Player2-scissors
        [TestMethod]
        public void DetermineWinner_SixthPathOfMethod_String()
        {
            // Arrange
            string Player1Val = "paper";
            string Player2Val = "paper";
            GamePlay myGame = new GamePlay(Player1Val, Player2Val);
            string expectedWinner = "NO WINNER, You both chosed paper";

            // Act
            string returnedWinner = myGame.DetermineWinner(Player1Val, Player2Val);

            // Assert
            Assert.AreEqual(expectedWinner, returnedWinner);
        }
        
         // 13th Test: Test Method DetermineWinner(); Seventh path: Player1-paper, Player2-scissors
        [TestMethod]
        public void DetermineWinner_SeventhPathOfMethod_String()
        {
            // Arrange
            string Player1Val = "scissors";
            string Player2Val = "paper";
            GamePlay myGame = new GamePlay(Player1Val, Player2Val);
            string expectedWinner = "Player 1";

            // Act
            string returnedWinner = myGame.DetermineWinner(Player1Val, Player2Val);

            // Assert
            Assert.AreEqual(expectedWinner, returnedWinner);
        }
        
         // 13th Test: Test Method DetermineWinner(); Eight path: Player1-paper, Player2-scissors
        [TestMethod]
        public void DetermineWinner_EightPathOfMethod_String()
        {
            // Arrange
            string Player1Val = "scissors";
            string Player2Val = "rock";
            GamePlay myGame = new GamePlay(Player1Val, Player2Val);
            string expectedWinner = "Player 2";

            // Act
            string returnedWinner = myGame.DetermineWinner(Player1Val, Player2Val);

            // Assert
            Assert.AreEqual(expectedWinner, returnedWinner);
        }
        
         // 14th Test: Test Method DetermineWinner(); Ninth path: Player1-paper, Player2-scissors
        [TestMethod]
        public void DetermineWinner_NinthPathOfMethod_String()
        {
            // Arrange
            string Player1Val = "scissors";
            string Player2Val = "scissors";
            GamePlay myGame = new GamePlay(Player1Val, Player2Val);
            string expectedWinner = "NO WINNER!, You both chosed scissors";

            // Act
            string returnedWinner = myGame.DetermineWinner(Player1Val, Player2Val);

            // Assert
            Assert.AreEqual(expectedWinner, returnedWinner);
        }
        
         // 15th Test: Test Method DetermineWinner(); Tenth path: Player1-paper, Player2-scissors
        // For Confirming user only enters: rock, paper, or scissors
        [TestMethod]
        public void DetermineWinner_TenthPathOfMethod_String()
        {
            // Arrange
            string Player1Val = "bola";
            string Player2Val = "ade";
            GamePlay myGame = new GamePlay(Player1Val, Player2Val);
            string expectedWinner = "NO ONE WINS, YOUR GAME INPUT WAs WRONG, only enter rock, paper, or scissors to see winner";

            // Act
            string returnedWinner = myGame.DetermineWinner(Player1Val, Player2Val);

            // Assert
            Assert.AreEqual(expectedWinner, returnedWinner);
        }
        

        // 16th Test: Test for List: Getting all Previous winners
        [TestMethod]
        public void GetAllGamePlays_ReturnsAListOfAllWinners_List()
        {
            // Arrange
            string Player1Val = "rock";
            string Player2Val = "ade";
            GamePlay myGame = new GamePlay(Player1Val, Player2Val);

            string Player1NewVal = "rock";
            string Player2NewVal = "scissors";
            GamePlay myGame2 = new GamePlay(Player1NewVal, Player2NewVal);
            
            string Player1NewVal2 = "paper";
            string Player2NewVal2 = "rock";
            GamePlay myGame3 = new GamePlay(Player1NewVal2, Player2NewVal2);
            
            List<GamePlay> recordList = new List<GamePlay>(){myGame, myGame2, myGame3};

            // Act
            List<GamePlay> myRecordList = GamePlay.GetAllGamePlays();

            // Assert
            CollectionAssert.AreEqual(recordList, myRecordList);

        }

         // 17th Test: Test to clear List: Clearing all Previous winners
        [TestMethod]
        public void ClearAllGamePlays_ReturnsAListOfAllWinners_List()
        {
            // Arrange
            string Player1Val = "rock";
            string Player2Val = "ade";
            GamePlay myGame = new GamePlay(Player1Val, Player2Val);

            string Player1NewVal = "rock";
            string Player2NewVal = "scissors";
            GamePlay myGame2 = new GamePlay(Player1NewVal, Player2NewVal);
            
            string Player1NewVal2 = "paper";
            string Player2NewVal2 = "rock";
            GamePlay myGame3 = new GamePlay(Player1NewVal2, Player2NewVal2);
            
            List<GamePlay> recordList = new List<GamePlay>(){myGame, myGame2, myGame3};
            List<GamePlay> expectedEmptyRecordList = new List<GamePlay>(){};

            // Act
           GamePlay.ClearAllGamePlays();

            // Assert
            // After clearing my list, I try to get it again and see that it truly returns an empty list after I did the clearing.
            CollectionAssert.AreEqual(expectedEmptyRecordList, GamePlay.GetAllGamePlays());

        }


    }
}