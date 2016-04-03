using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes_And_Ladders
{
    public partial class frm_SnakesAndLaddersBoard : Form
    {
        //-------------------------------------Declaration of Global Variables-------------------------------------\\

        //Seperate arrays for each player so that finding positions is correct
        Point[] boardSqauresForPlayer1 = new Point[101];
        Point[] boardSqauresForPlayer2 = new Point[101];

        //Using board positions
        int[] snakeHeads =new int[]{17, 54, 62, 64, 87, 93, 95, 98};
        int[] snakeEnds = new int[]{ 7, 34, 19, 60, 24, 73, 75, 79};
        int[] ladderStarts = new int[] { 1, 4, 9, 21, 28, 51, 71, 80};
        int[] ladderEnds = new int[] { 38, 14, 31, 42, 84, 67, 91, 100};

        int boardPositionPlayer1 = 0;
        int boardPositionPlayer2 = 0;
        int turn = 1;

        //-------------------------------------End Declaration of Global Variables-------------------------------------\\



        public frm_SnakesAndLaddersBoard()
        {
            InitializeComponent();            
        }



        private void btn_Start_Click(object sender, EventArgs e)
        {
            //Turn invisible
            btn_Start.Visible = false;

            //Set up point array
            SetUpBoard(ref boardSqauresForPlayer1, ref boardSqauresForPlayer2);

            //Inform of whose turn it is
            lbl_PlayerThatIsGoing.Text = "Player 1's turn";

            //Enable die rolling ability
            btn_rollDie.Enabled = true;

        }//End Start Button click



        //sets up the point array for the board
        public static void SetUpBoard(ref Point[] boardSqauresForPlayer1, ref Point[] boardSqauresForPlayer2)
        {
            //-------------------------------Declaration Of Variables-------------------------------\\
            
            int changeInBoardPosition = 60;
            int startOfRow = 1;
            int endOfRow = 11;
            int xBoard = -35;
            int yBoardPlayer1 = 538;
            int yBoardPlayer2 = 564;

            //-------------------------------Declaration Of Variables-------------------------------\\

            //Starting position added to the arrays
            boardSqauresForPlayer1[0] = new Point { X = xBoard, Y = yBoardPlayer1 };
            boardSqauresForPlayer2[0] = new Point { X = xBoard, Y = yBoardPlayer2 };

            //Set up first row
            setUpRow(ref boardSqauresForPlayer1, ref boardSqauresForPlayer2, changeInBoardPosition, startOfRow, endOfRow, ref xBoard, yBoardPlayer1, yBoardPlayer2);

            for (int rowNumber = 2; rowNumber < 11; rowNumber++)
            {
                if (rowNumber % 2 != 0)
                {
                    //If the row is even it must be going from left to right i.e to the right
                    SetUpToTheLeft(ref boardSqauresForPlayer1, ref boardSqauresForPlayer2, ref changeInBoardPosition, ref startOfRow, ref endOfRow, ref xBoard, ref yBoardPlayer1, ref yBoardPlayer2);
                }
                else
                {
                    //If the row is odd it must be going from right to left i.e to the left
                    SetUpToTheRight(ref boardSqauresForPlayer1, ref boardSqauresForPlayer2, ref changeInBoardPosition, ref startOfRow, ref endOfRow, ref xBoard, ref yBoardPlayer1, ref yBoardPlayer2);

                }//End row number even if

            }//End Row setup for
                       

        }//End SetUpBoard



        private static void SetUpToTheLeft(ref Point[] boardSqauresForPlayer1, ref Point[] boardSqauresForPlayer2, ref int changeInBoardPosition, ref int startOfRow, ref int endOfRow, ref int xBoard, ref int yBoardPlayer1, ref int yBoardPlayer2)
        {
            //Set new y values for each player and the increment amount
            yBoardPlayer1 = yBoardPlayer1 - 58;
            yBoardPlayer2 = yBoardPlayer2 - 58;
            changeInBoardPosition = 60;
            startOfRow = endOfRow + 1;
            endOfRow = endOfRow + 10;

            //Set up the first square of the third row
            boardSqauresForPlayer1[startOfRow - 1] = new Point { X = xBoard, Y = yBoardPlayer1 };
            boardSqauresForPlayer2[startOfRow - 1] = new Point { X = xBoard, Y = yBoardPlayer2 };

            //Set up third row
            setUpRow(ref boardSqauresForPlayer1, ref boardSqauresForPlayer2, changeInBoardPosition, startOfRow, endOfRow, ref xBoard, yBoardPlayer1, yBoardPlayer2);
        }



        private static void SetUpToTheRight(ref Point[] boardSqauresForPlayer1, ref Point[] boardSqauresForPlayer2, ref int changeInBoardPosition, ref int startOfRow, ref int endOfRow, ref int xBoard, ref int yBoardPlayer1, ref int yBoardPlayer2)
        {
            //Set new y values for each player and the increment amount
            yBoardPlayer1 = yBoardPlayer1 - 58;
            yBoardPlayer2 = yBoardPlayer2 - 58;
            changeInBoardPosition = -60;
            startOfRow = endOfRow + 1;
            endOfRow = endOfRow + 10;

            //Set up the first square of the second row
            boardSqauresForPlayer1[startOfRow - 1] = new Point { X = xBoard, Y = yBoardPlayer1 };
            boardSqauresForPlayer2[startOfRow - 1] = new Point { X = xBoard, Y = yBoardPlayer2 };

            //Set up second row
            setUpRow(ref boardSqauresForPlayer1, ref boardSqauresForPlayer2, changeInBoardPosition, startOfRow, endOfRow, ref xBoard, yBoardPlayer1, yBoardPlayer2);
        }


        //Sets up the point array for that row
        private static void setUpRow(ref Point[] boardSqauresForPlayer1, ref Point[] boardSqauresForPlayer2, int changeInBoardPosition, int startOfRow, int endOfRow, ref int xBoard, int yBoardPlayer1, int yBoardPlayer2)
        {

            for (int boardPosition = startOfRow; boardPosition < endOfRow; boardPosition++)
            {
                //Increment the x co-ordinate
                xBoard = xBoard + changeInBoardPosition;

                //Position added to the arrays
                boardSqauresForPlayer1[boardPosition] = new Point { X = xBoard, Y = yBoardPlayer1 };
                boardSqauresForPlayer2[boardPosition] = new Point { X = xBoard, Y = yBoardPlayer2 };

            }            

        }//End SetUpRow



        private void btn_rollDie_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();         

            int diceRoll = rnd.Next(1, 7);


            switch (diceRoll)
            {
                case 1:
                    pbx_Diceface.Image = imageList2.Images[diceRoll - 1];
                    break;

                case 2:
                    pbx_Diceface.Image = Snakes_And_Ladders.Properties.Resources.diceFace2;
                    break;

                case 3:
                    pbx_Diceface.Image = Snakes_And_Ladders.Properties.Resources.diceFace3;
                    break;

                case 4:
                    pbx_Diceface.Image = Snakes_And_Ladders.Properties.Resources.diceFace4;
                    break;

                case 5:
                    pbx_Diceface.Image = Snakes_And_Ladders.Properties.Resources.diceFace5;
                    break;

                case 6:
                    pbx_Diceface.Image = Snakes_And_Ladders.Properties.Resources.diceFace6;
                    break;

            }

            //If the first time the player moves
            if (turn == 1)
            {
                pbx_Player1.Visible = true;
            }
            else if (turn == 2)
            {
                pbx_Player2.Visible = true;
            }
            

            //if odd turn first player else second player
            if (turn % 2 != 0)
            {
                //Increase board Position for player 1
                boardPositionPlayer1 = boardPositionPlayer1 + diceRoll;

                ////If player is at 100 or 80 (because 80 has a ladder to 100 which is win condition)
                if (boardPositionPlayer1 >= 100 || boardPositionPlayer1 == 80)
                {
                    //make it apparant that a player won
                    WinnerLabel(" 1");
                }
                else
                {
                    //Check board position i.e Check If On a Snake Or a Ladder
                    boardPositionPlayer1 = CheckIfOnSnakeOrLadder(boardPositionPlayer1, snakeHeads, snakeEnds, ladderStarts, ladderEnds);

                    //Increase to board position
                    pbx_Player1.Location = boardSqauresForPlayer1[boardPositionPlayer1];

                    //Increase turn
                    turn = turn + 1;

                    lbl_PlayerThatIsGoing.Text = "Player 2's turn";

                }//End Player 1 win or move if statement

            }
            else
            {
                //Increase board Position for player 2
                boardPositionPlayer2 = boardPositionPlayer2 + diceRoll;

                //If player is at 100 or 80 (because 80 has a ladder to 100 which is win condition)
                if (boardPositionPlayer2 >= 100 || boardPositionPlayer2 == 80)
                {
                    //make it apparant that a player won
                    WinnerLabel(" 2");
                }
                else
                {
                    //Check board position i.e Check If On a Snake Or a Ladder
                    boardPositionPlayer2 = CheckIfOnSnakeOrLadder(boardPositionPlayer2, snakeHeads, snakeEnds, ladderStarts, ladderEnds);

                    //Increase to board position
                    pbx_Player2.Location = boardSqauresForPlayer2[boardPositionPlayer2];

                    //Increase turn
                    turn = turn + 1;

                    lbl_PlayerThatIsGoing.Text = "Player 1's turn";

                }//End Player 2 win or move if statement

            }//End odd turn if statement

        }//End btn_rollDie_Click



        private static int CheckIfOnSnakeOrLadder(int boardPosition, int[] snakeHeads, int[] snakeEnds, int[] ladderStarts, int[] ladderEnds)
        {
            /*
             * for all elements in snake head array
                 * check if board position is held in snake heads array
                 * if true return position
             * for all elements in ladder starts array
                 * if board position is held in ladder starts array
                 * if true return position
             */

            //for all elements in snake head array
            for (int arrayPosition = 0; arrayPosition < snakeHeads.Length; arrayPosition++)
            {
                //check if board position is held in snake heads array
                if (boardPosition == snakeHeads[arrayPosition])
                {
                    //inform of their misforutune
                    MessageBox.Show("You hit a snake.\nHAHA");

                    //if true return position
                    return snakeEnds[arrayPosition];
                    

                }//End if

            }//End for


            //for all elements in ladder starts array
            for (int arrayPosition = 0; arrayPosition < ladderStarts.Length; arrayPosition++)
            {
                //if board position is held in ladder starts array
                if (boardPosition == ladderStarts[arrayPosition])
                {
                    //inform of their forutune
                    MessageBox.Show("You went up a ladder.\nCongratulations!");

                    //if true return position
                    return ladderEnds[arrayPosition];

                }//End if

            }//End for

            //if not included
            return boardPosition;

        }//End CheckIfOnSnakeOrLadder



        private void WinnerLabel(string whoWon)
        {
            //Make winner labels visible
            lbl_winnerTitle.Visible = true;
            lbl_winnerIs.Visible = true;
            lbl_winnerIs.Text = lbl_winnerIs.Text + whoWon;
            btn_rollDie.Enabled = false;

        }//End WinnerLabel
        
    }
}
