using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3280_Assignment4
{
    public partial class Form1 : Form {

        //adding in the game logic class
        GameLogic _gameLogic = new GameLogic();

        //player class has 2 values, X and O
        public enum Player
        {
            X, O
        }

        Player currentPlayer; //using the player class
        Random rand = new Random(); //new random number generator
        int playerWins = 0; //keeping track of how often the player has won
        int compWins = 0; //keeping track of how often the AI has won
        List<Button> buttons; //creating the array of buttons


        public Form1()
        {
            InitializeComponent();
            startGame(); 
        }



        private void startGame(object sender, EventArgs e)
        {
            //when the stat game button is clicked this function will run the start game function
            startGame(); 
        }

        public void startGame()
        {
            //check each of the buttons that have the play tag
            foreach (Control X in Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true; //make all of the buttons clickable
                    ((Button)X).Text = ""; //clear the text on the buttons
                    ((Button)X).BackColor = default(Color); //change the background color to the default color
                }
            }
            loadbuttons(); //run the load buttons function so that all of the buttons are in the list
        }

        public void loadbuttons()
        {
            //this will load all of the buttons from the form to the buttons list
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 }; 
        }

        public void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender; //figure out which button was clicked

            currentPlayer = Player.X; //sets the player to X
            button.Text = currentPlayer.ToString(); //show O on the button
            button.Enabled = false; //disable the clicked button
            buttons.Remove(button); //remove the button from the list
            Check(); //check if the player has won
            AImoves.Start(); //start the AI timer
        }

        public void AImove(object sender, EventArgs e)
        {
            //randomly choose a button from the list to click
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count); //generate a random number within the number of buttons available
                buttons[index].Enabled = false; //disable the button
                currentPlayer = Player.O; //set the AI with O
                buttons[index].Text = currentPlayer.ToString(); //show O on the button
                buttons.RemoveAt(index); //remove the button from the list
                Check(); //see if the AI has won
                AImoves.Stop(); //stop the AI timer
            }
        }
        public void Check()
        {
            //check if the AI or the player has won

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                AImoves.Stop(); //stop the timer
                MessageBox.Show("Player Wins"); //show a message to the player
                playerWins++; //increase the player wins
                label1.Text = "Player Wins- " + playerWins; //update the label
                startGame(); //run the start game function

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
     || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
     || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
     || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
     || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
     || button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
     || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
     || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
     || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                AImoves.Stop(); //stop the timer
                MessageBox.Show("Computer Wins"); //show a message to the player
                compWins++; //increase the computer wins
                label2.Text = "AI Wins- " + compWins; //update the label
                startGame(); //run the start game function

            }
            else if (buttons.Count == 0)
            {
                AImoves.Stop(); //stop the timer
                MessageBox.Show("Tie"); //show a message to the player
                compWins++; //increase the computer wins
                label2.Text = "AI Wins- " + compWins; //update the label
                startGame(); //run the start game function
            }
        }
    }
}
