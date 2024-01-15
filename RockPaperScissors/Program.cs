using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors.Models
{
    
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                static void GameRules()
                {
                    
                    Console.WriteLine("           --> Enter 'Rock' to chose Rock");
                    Console.WriteLine("           --> Enter 'Scissors' to chose Scissors");
                    Console.WriteLine("           --> Enter 'Paper' to chose Paper");

                }


                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Welcome to the Rock Paper Scissors Game");
                Console.WriteLine("---------------------------------------");

                Console.WriteLine();
                Console.WriteLine("NOTE: The Game is on repeat mode, but to quit game; enter: Ctrl+C");
                Console.WriteLine();
                Console.WriteLine("Here are the rules for the game: ");

                GameRules();

                Console.WriteLine();
                Console.WriteLine("Enter '1' to play with computer, '2' for multiplayer(play with a friend)");
                string userOption = Console.ReadLine().ToUpper();
                int userOptionInt = int.Parse(userOption);
                Console.WriteLine();
                switch (userOptionInt)
                {
                    case 1:
                        Console.WriteLine("Single Player Mode: You are now playing with the computer");

                        // Generating Computers mode with the inbuilt C# random class
                    static string GetComputerVal()
                    {
                            Random randNo = new Random();
                            int randNoInt = randNo.Next(1, 4); // above generates a number, on this line I tell it the range I want
                            
                    
                            if(randNoInt == 1)
                            {
                                return "rock";
                            }
                            
                            else if(randNoInt == 2)
                            {
                                return "paper";
                            }
                            
                            else if(randNoInt == 3)
                            {
                                return "scissors";
                            }

                            else
                            {
                                return "no number retrieved";
                            }
                    }

                    Console.WriteLine();

                    try
                    {
                            Console.WriteLine("Select your own value: You are Player 1");
                            Console.WriteLine();
                            GameRules();
                            string userVal = Console.ReadLine().ToLower();
                            Console.WriteLine();

                            // Getting computers value
                            string myCompVal = GetComputerVal();
                            Console.WriteLine($"Computer choosed {myCompVal}");
                            Console.WriteLine();

                            GamePlay newGame = new GamePlay(userVal, myCompVal);
                            string soloPlayWinner = newGame.DetermineWinner(userVal, myCompVal);

                            Console.WriteLine($"And the winner is: {soloPlayWinner}");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                    }
                    catch
                    {
                            Console.WriteLine("-------------------");
                            Console.WriteLine("Error!!!!! Ensure you enterred either rock, paper or scissors. Please Try again.");
                            Main();
                            Console.WriteLine("-------------------");
                    }




                        
                        break;


                    case 2:
                        Console.WriteLine("Multiplayer Mode: You are now playing with the computer");

                        Console.WriteLine();
                        Console.WriteLine("Enter 'Y' to continue or 'N' to end game");
                        string userContinue = Console.ReadLine().ToUpper();
                        Console.WriteLine();

                        switch (userContinue)
                        {
                            case "Y":
                                Console.WriteLine("Okay, enter any of the following for Player 1:");
                                Console.WriteLine();
                                GameRules();
                                Console.WriteLine();

                                string userVal = Console.ReadLine().ToLower();
                            
                                Console.WriteLine("Okay, enter any of the following for Player 2:");
                                Console.WriteLine();
                                GameRules();
                                Console.WriteLine();

                                string userVal2 = Console.ReadLine().ToLower();
                                Console.WriteLine();

                                GamePlay newGame = new GamePlay(userVal, userVal2);
                                string myWinner = newGame.DetermineWinner(userVal, userVal2);

                                Console.WriteLine($"And the winner is: {myWinner}");

                                
                                break;
                            case "N":
                                Console.WriteLine();
                                Console.WriteLine("Goodbye My dear User");
                                break;
                            default:
                                Console.WriteLine("Something went wrong, ensure you enterred the right input. Try again");
                                Main();
                                break;
                        }
                        break;


                    default:
                        Console.WriteLine("Something went wrong, ensure you enterred the right input. Try again");
                        Main();
                        break;
                }
                }
            

           
            


        }
    }
}