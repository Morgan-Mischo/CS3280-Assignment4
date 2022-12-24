using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3280_Assignment4
{
    public class GameLogic
    {
        Form1 _form1 = new Form1();
        //player class has 2 values, X and O
        public enum Player
        {
            X, O
        }

        Player currentPlayer; //using the player class
        Random rand = new Random(); //new random number generator
        int playerWins = 0; //keeping track of how often the player has won
        int compWins = 0; //keeping track of how often the AI has won
    }
}
