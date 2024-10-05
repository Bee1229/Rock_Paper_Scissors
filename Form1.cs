using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Rock_Paper_Scissor
{
    public partial class Form1 : Form
    {
        private GameLogic gameLogic= new GameLogic(); //An instance for game logic 
        private string PlayerChoice; // stores the Players choice 
        private int timeperRound = 6; //time per round 


        // Initializes the form and resets the game UI.
        public Form1()
        {
            InitializeComponent();
            ResetGameUI();
        }

        // Resets the UI to its initial state.
        public void ResetGameUI()
        {
            txtTimer.Text = "5";

            PicPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;

            txtRound.Text = "Round: 3";
            
            txtScore.Text = "Player: 0      CPU: 0";

            PlayerChoice = "None";
            
            CountDown.Enabled = true;

        }

        //Event handlers for button clicks. Set the player's choice and update the UI.
        private void btnRock_Click(object sender, EventArgs e)
        {
            PicPlayer.Image = Properties.Resources.rock;
            PlayerChoice = "Rock";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PicPlayer.Image = Properties.Resources.paper;
            PlayerChoice = "Paper";
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            PicPlayer.Image = Properties.Resources.scissors;
            PlayerChoice = "Scissors";
        }

        //Handles the countdown for each round. It decreases timeperRound, updates the UI, and at the end of the countdown.
        //it computes the round's result and updates scores.
        private void CountDownEvent(object sender, EventArgs e)
        {

            timeperRound --;
            txtTimer.Text = timeperRound.ToString();
            txtRound.Text = "Round: " + gameLogic.GetCurrentRound(); //this shows the current round of the game 

              
            //the if loop is the main part of the game it chacks the time per round 
            if (timeperRound < 1)
            {
                CountDown.Enabled = false; 
                timeperRound = 6;

                string CPUchoice = gameLogic.GenerateCPUChoice(); // created a varable for cpu choices that is grentrated randomly 
                UpdateCPUImage(CPUchoice); //this updates the cpu image to the choice generated 


                //This structure is used for error handling.
                //It attempts to execute the code inside the try block, and if an exception occurs,
                //it catches the exception and executes the code inside the catch block instead.
                try
                {
                    string result = gameLogic.ChecRoundWinner(PlayerChoice, CPUchoice);
                    MessageBox.Show(result); //It's a way to show notifications or information in Windows Forms applications.
                    UpdateScore();
                }
                catch (InvalidOperationException ex) // handles invalid Operation Expection when the player doesn't make a selection
                {
                    MessageBox.Show(ex.Message); //if an exception happens this informs the user of what went wrong 
                }

                StartNextRound(); 

                UpdateScore();

                NextRoundUI();
               
            }
          
           
        }
        //method to begin the next round in the user interface 
        private void NextRoundUI()
        {
            txtTimer.Text = "5";

            PicPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;

            txtRound.Text = "Round: " + gameLogic.GetCurrentRound();
            
            PlayerChoice = "None";

            CountDown.Enabled = true;

        }
     
        //method to update the score 
        private void UpdateScore()
        { 
                txtScore.Text = "Player: " + gameLogic.GetPlayerScore() + "      CPU: " + gameLogic.GetCPUScore();
            
        }

        //Checks the winner of the game and resets the game
        private void StartNextRound()
        {
            if (gameLogic.IsGameOver())
            {

                MessageBox.Show(gameLogic.GetWinner());
                var result = MessageBox.Show("Do you want to play again?", "Game Over",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    //User chose to restart the game
                    gameLogic.ResetGame();
                    ResetGameUI();
                }
                else
                {
                    this.Close(); //Closes the form, effectively ending the game
                }
                return;

            }
        }

        //enables the reset button to start the game a freash 
        private void btnReset_Click(object sender, EventArgs e)
        {
            gameLogic.ResetGame();
            ResetGameUI();

        }

        // method to update the cpu image 
        private void UpdateCPUImage(string CPUChoice)
        {
            switch (CPUChoice)
            {
                case "Rock":
                    picCPU.Image = Properties.Resources.rock;
                    break;

                case "Paper":
                    picCPU.Image = Properties.Resources.paper;
                    break;

                case "Scissors":
                    picCPU.Image = Properties.Resources.scissors;
                    break;
                default:
                    picCPU.Image = null;
                    break;
            }
        }
   
    }
}