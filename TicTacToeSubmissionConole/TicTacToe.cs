using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer; // lives throughout this class (_boardRenderer)
        private int[] _boardPositions = new int[9];
        private int _rounds;

        private void PlayMove(int player)
        {
            // ask user for row and column

            Console.SetCursorPosition(2, 19);

            if (player == 1)
              Console.Write("Player X");
            else
                Console.Write("Player O");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);


            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();


            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
          //  _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);


            // store move in array

            int rowNumber = int.Parse(row);
            int columnNumber = int.Parse(column);
            int arrayPos = (rowNumber * 3) + columnNumber;

            _boardPositions[arrayPos] = player;

            // add move to the board
            if (player == 1)

            _boardRenderer.AddMove(rowNumber, columnNumber, PlayerEnum.X, true);
            else 
                _boardRenderer.AddMove(rowNumber, columnNumber, PlayerEnum.O, true);
            

        }


        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
            // render means show to screen 
        }
        private void PlayMoveX()
        {
            // ask user for row and column

            Console.SetCursorPosition(2, 19);

            Console.Write("Player X");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);


            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();


            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);


            // store move in array

            int rowNumber = int.Parse(row);
            int columnNumber = int.Parse(column);
            int arrayPos = (rowNumber * 3) + columnNumber;

            _boardPositions[arrayPos] = 1;

            // add move to the board
            _boardRenderer.AddMove(rowNumber, columnNumber, PlayerEnum.X, true);

        }

        /*private void PlayMoveO()
        {

        }*/

        public bool CheckIfPlayerWins(int player)

            // across
        {
            if ((_boardPositions[0] == player) && (_boardPositions[1] == player) && (_boardPositions[2] == player))
                return true;

            if ((_boardPositions[3] == player) && (_boardPositions[4] == player) && (_boardPositions[5] == player))
                return true;

            if ((_boardPositions[6] == player) && (_boardPositions[7] == player) && (_boardPositions[8] == player))
                return true;

            //down

            if ((_boardPositions[0] == player) && (_boardPositions[3] == player) && (_boardPositions[6] == player))
                return true;

            if ((_boardPositions[1] == player) && (_boardPositions[4] == player) && (_boardPositions[7] == player))
                return true;

            if ((_boardPositions[2] == player) && (_boardPositions[5] == player) && (_boardPositions[8] == player))
                return true;

             // diagonal
            if ((_boardPositions[0] == player) && (_boardPositions[4] == player) && (_boardPositions[8] == player))
                return true;

            if ((_boardPositions[2] == player) && (_boardPositions[4] == player) && (_boardPositions[6] == player))
                return true;


            return false;
        }

        public void Run() // methord returns nothing. and reason its public is so it can be accessed outside class
        {
            _rounds = 0;
            bool playerXWins = false;
            bool playerOWins = false;

            while (_rounds < 4)
            {
                // play X

                PlayMove(1);

                
                playerXWins = CheckIfPlayerWins(1);
             
                if (playerXWins)
                { 
                    Console.WriteLine("Player X Wins");

                    break;
                }

                // play O

                PlayMove(2);

                playerOWins = CheckIfPlayerWins(2);
                if (playerOWins)
                {
                    Console.WriteLine("Player O Wins");
                    break;
                }

                // check if X won

                    // if X won, exit

                // check if O won

                    // if O won, exit
 
                _rounds++;

            }
            ////////////////
            ///
            if (!playerOWins && !playerXWins)
                Console.WriteLine("DRAW!");

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

           /* Console.SetCursorPosition(2, 19);

            Console.Write("Player X");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);


            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();


            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);            

            */
        }

    }
}
