using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissor
{  
    //GameLogic is a constroctor to hold all the logic of the game 
    public class GameLogic 
    {
        // created a flied for the actions need for the game to work
        private int round; //holds the number of rounds in the game
        private bool gameOver; //ends the game
        private string[] CPUChoiceList = { "Rock", "Paper", "Scissors", "Paper", "Scissors", "Rock" }; //this helps the cpu loop through the option proberly 
        private Random Rand = new Random();// helps the cpu selection to be random
        private int CPUScore; //provides the cpu score
        private int PlayerScore;////provides the players score

        public GameLogic()
        {
            ResetGame(); // Initializes the game by calling resetgame
        }

        //A method for the reset game that provides the intial look of the game 
        public void ResetGame()
        {
            round = 3;
            CPUScore = 0;   
            PlayerScore = 0;
            gameOver = false;
        }

        //a method that returns the current round.
        public int GetCurrentRound()
        {
            return round;
        }

        //a methid that selcets the cpu choice randomly 
        public string GenerateCPUChoice()
        {
            int randonNumber = Rand.Next(CPUChoiceList.Length);
            return CPUChoiceList[randonNumber];
        }

        // a method to check the winner of each round, updte the score and reduce the round 
        public string ChecRoundWinner(string PlayerChoice, string CPUChoice)
        {
            string result;

            if (PlayerChoice == "Scissors" && CPUChoice == "Paper")
            {
                PlayerScore++;
                round--;
                result = "Player wins, Scissors cuts Paper";

            }

            else if (PlayerChoice == "Rock" && CPUChoice == "Scissors")
            {
                PlayerScore++;
                round--;
                result = "Player wins, Rock breaks Scissors";
            }

            else if (PlayerChoice == "Paper" && CPUChoice == "Rock")
            {
                PlayerScore ++;
                round--;
                result = "Player wins, Paper cover Rock";
            }


            else if (PlayerChoice == "Scissors" && CPUChoice == "Rock")
            {
                CPUScore++;
                round--;
                result = "CPU wins, Rock breaks Scissors";
            }
            else if (PlayerChoice == "Rock" && CPUChoice == "Paper")
            {
                CPUScore ++;
                round--;
                result = "CPU wins, Paper covers Rock";

            }   
            else if (PlayerChoice == "Paper" && CPUChoice == "Scissors")
            {
                CPUScore ++;
                round--;
                result = "CPU wins, Scissors cuts Paper";
            } 
            else if (PlayerChoice == CPUChoice)
            {
                result = "It's a tie!!";
            }
            else 
            {
                throw new InvalidOperationException("Player did not make a choice"); //this exception is thrown when the player doesn't make a choice 
            }  
          
            if (round <= 0) //this loop is to check if the game is over 
            {
               
                gameOver = true;
                   
            }

            return result; //the results is shown at the end of every game

          
      
        }

        //method to return game over 
        public bool IsGameOver()
        {
            return gameOver;
        }

        //method to return players score
        public int GetPlayerScore()
        {
            return PlayerScore;
        }

        //method to return cpu score
        public int GetCPUScore()
        {
            return CPUScore;    
        }

        //method to to check the winner at the end of  the last rounnd 
        public string GetWinner()
        {
            if (PlayerScore > CPUScore)
                return "Player won the game";
            else if (CPUScore > PlayerScore)
                return "CPU won the game";
            else
                return "It's a tie!";
        }
     
    }
}
