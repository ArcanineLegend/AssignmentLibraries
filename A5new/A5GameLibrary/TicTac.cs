using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace TicTacToe
{
    public class TicTac : IPlayable
    {
        static void Main(string[] args)
        {
            //TicTac p = new TicTac();
            //p.Start();
            Player p = new Player();
            TicTac t = new TicTac();
            Game g = new Game();

            Console.WriteLine("Please enter your name: ");
            p.Initialize(new ConsoleStringGetter());
            Console.WriteLine(p.Greet());
        }

        public class ConsoleStringGetter : StringGetter
        {
            public string GetInput()
            {
                return Console.ReadLine();
            }
        }

        public interface StringGetter
        {
            string GetInput();
        }


        
        char[,] board = new char[3,3];
        Player[] players;

        public TicTac()
        {
            players = new Player[2];

            //Random names from http://www.behindthename.com/random/ 
            //The names are Greek ;)
            players[0] = new Player() { Name = "Player 1: Theophania", Token = 'X' }; //using object initialization syntax
            players[1] = new Player() { Name = "Player 2: Xenon", Token = 'O' };  
        }


        /// <summary>
        /// The Tic Tac Toe game loop, 2 players.  Iterate player turns until the game
        /// is over
        /// </summary>
        

        /// <summary>
        /// Get and set the player's desired location on the board
        /// </summary>
        /// <param name="activePlayer"></param>
        


        /// <summary>
        /// Give the user instructions for piece placement and return
        /// the 2D location of the position they select
        /// </summary>
        /// <param name="activePlayer"></param>
        /// <returns></returns>
        


        /// <summary>
        /// Converts a single number entered by the user to an X,Y element for reference
        /// in a 2D array
        /// </summary>
        /// <param name="boardPosition">The single number to be converted</param>
        /// <returns>The X,Y position intended to be used with a 2D array</returns>
       

        /// <summary>
        /// Prints a number for every position on the board to help the user
        /// know what single number to enter
        /// </summary>
        private void PrintBoardMap()
        {
            int position = 1; //1-based board map (done for user experience)

            for (int row = 0; row <= board.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= board.GetUpperBound(1); column++)
                {
                    Console.Write(position++);
                    if (column < board.GetUpperBound(1))
                    {
                        Console.Write(" - ");
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Prints the board to the console with extra dashes for legibility
        /// </summary>
        private void PrintBoard()
        {
            Console.WriteLine();
            for (int row = 0; row <= board.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= board.GetUpperBound(1); column++)
                {
                    Console.Write(board[row,column]);

                    //only print the dashes for the inner columns
                    if (column < board.GetUpperBound(1))
                    {
                        Console.Write(" - ");
                    }
                    {
                        {                                                                                                                                                                                                                                                                                                                                                                 /*Congrats!  You found the easter egg!  Weren't those useless curly brackets annoying? Plus one was missing.... way out here on column 500+*/                                                         }
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// You didn't think I'd write every method for you, did you?
        /// </summary>
        /// <returns></returns>
        private bool GameOver()
        {
            //if three in a row or all spaces are filled
            return false;
        }
        public static bool Win(int CurrentRow, int CurrentColumn, Enum Token)
        {

            if (GameLibrary.SquareValue(CurrentRow, 0) == Token //for example 0 is actually 1 and 1 is two...
                 && Board.SquareValue(CurrentRow, 1) == Token
                 && Board.SquareValue(CurrentRow, 2) == Token
            || Board.SquareValue(0, CurrentColumn) == Token
                 && Board.SquareValue(1, CurrentColumn) == Token
                 && Board.SquareValue(2, CurrentColumn) == Token
            || CurrentRow == CurrentColumn
                 && Board.SquareValue(0, 0) == Token
                 && Board.SquareValue(1, 1) == Token
                 && Board.SquareValue(2, 2) == Token
            || CurrentRow + CurrentColumn == 2
                 && Board.SquareValue(0, 2) == Token
                 && Board.SquareValue(1, 1) == Token
                 && Board.SquareValue(2, 0) == Token)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public interface IPlayable(){

    }

    

}
