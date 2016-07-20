using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
   
    public class Game
    {
        Player activePlayer;
        private void Start(int activePlayer)
        {
            int indexOfCurrentPlayer = 0;
            activePlayer = players[indexOfCurrentPlayer];

            while (!GameOver())
            {
                
                Console.WriteLine("Here is the board:");
                Board.PrintBoard();

                Player.TakeTurn(activePlayer);
                //select the other player
                indexOfCurrentPlayer = (indexOfCurrentPlayer == 0) ? 1 : 0;
                activePlayer = players[indexOfCurrentPlayer];

                //Added this slight delay for user experience.  Without it it's harder to notice the board repaint
                //try commenting it out and check out the difference.  Which do you prefer?
                System.Threading.Thread.Sleep(300);

                Console.Clear();
            }
        }
        public static bool GameOver()
        {
            
            return false;
        }
        


    }
    public class Board
    {
        public Array GridArray;
        public Array Grid(int Row, int Col)// give the Row and Col, it will create the Grid and you set it to a local Array(in game).
        {
            GridArray = new char[Row, Col];
            return GridArray;
        }
        public char SquareValue(int Row, int Col)//set the saved array from the game Created above and give it to Square value to find the tokan value in the square tile.
        {
            char TokenValue = GridArray[Row, Col];
            return TokenValue;
        }
        public void PrintBoardMap()
        {
            int position = 1; //1-based board map (done for user experience)

            for (int row = 0; row <= GridArray.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= GridArray.GetUpperBound(1); column++) /// use this to fix grid array issues
                {
                    Console.Write(position++);
                    if (column < GridArray.GetUpperBound(1))
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
        public void PrintBoard()
        {
            Console.WriteLine();
            for (int row = 0; row <= GridArray.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= GridArray.GetUpperBound(1); column++)
                {
                    Console.Write(GridArray[row, column]);

                    //only print the dashes for the inner columns
                    if (column < GridArray.GetUpperBound(1))
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


    }
    public class ErrorMessages
    {
        public static void IllegalMove()
        {
            System.Console.WriteLine("IllegalMove");
        }
    }
    public class Player
    {
        public static String Name() {
            String playerName = Console.ReadLine();
            return playerName;
    }
        public void TakeTurn(Player activePlayer)
        {
            int[] position = PiecePlacement(activePlayer);
            board[position[0], position[1]] = activePlayer.Token;
        }
        private int[] PiecePlacement(Player activePlayer)
        {
            //you need to be using the .NET framework 4.6 for this line to work (C# 6)
            Console.WriteLine();
            Console.WriteLine(activePlayer.Greet());

            Console.WriteLine($"{activePlayer.Name}, it's your turn:");
            Console.WriteLine("Make your move by entering the number of the sqaure you'd like to take:");
            Board.PrintBoardMap(GridArray);
            Console.Write("Enter the number: ");

            //todo: Prevent returning a location that's already been used

            return ConvertToArrayLocation(Console.ReadLine());
        }
        public int[] ConvertToArrayLocation(string boardPosition)
        {
            int position = Int32.Parse(boardPosition);
            position--; //reduce position to account for 1-based board map (done for user experience)
            int row = position / 3;
            int column = position % 3;
            return new int[] { row, column }; //inline array initialization
        }
    }

}
