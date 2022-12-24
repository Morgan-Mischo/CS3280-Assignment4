# CS3280-Assignment4
Assignment 4 from CS 3280 - Object Oriented Windows using C# at Weber State University with Shawn Crowder

Create a Tic-Tac-Toe game that can be played by two players.  The form will consist of a Tic-Tac-Toe board in which the users’ click on to choose their space.  As the game is being played the Game Status section will tell whose turn it is.  When someone wins or there is a tie, a message will be displayed in the Game status section telling the users the status.  When someone wins the game the winning move needs to be indicated.  There also needs to be a section that keeps track of the number of wins for each player, and the number of ties.  When the game is finished, the user may click the “Start Game” button to start a new game.
This program will consist of the main form and at least one class that will define the rules of the game.  This class will have an array that is passed in through a property that represents the game board.  The class will then have methods within it that determines if someone won, if there is a tie, or if neither has occurred yet.  Make sure all business logic is in a separate class and not behind the UI.
 
EXTRA CREDIT (10 Points)
Create a computer player that can be played against.  The computer player will need to be smart enough to make a winning move or to block a winning move.  The AI code will need to be in a separate AI business logic class.
Commonly Missed Items
- Should have one method that takes care of all button clicks, which was described in the lecture and sample code.  If the program had to be updated it would have to be fixed in every method that has been copied and pasted.
- All attributes and methods need XML comments.
- All class attributes need an XML comment.
- All business logic is behind the UI.  The major concept behind this assignment is using classes to abstract out the business logic into a separate class.
- Requirement to highlight the winning move.
- After the game is over, moves shouldn't be allowed to be made
- Make sure to watch the lectures.  The lecture I gave on Tic Tac Toe outlined the entire assignment and showed every method and attribute that should have been created.
