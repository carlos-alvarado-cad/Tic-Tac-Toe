using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] ticTacToeBoard = new char[,]
            {
            { '-', '-', '-' },
            { '-', '-', '-' },
            { '-', '-', '-' }
            };

            for (int turns = 0; turns < 9; turns++)
            {
                Play(ticTacToeBoard, 'X');
                if (DidPlayerWin(ticTacToeBoard) == true)
                {
                    Console.WriteLine("Player X won!");
                    break;
                }
                Play(ticTacToeBoard, 'O');
                if (DidPlayerWin(ticTacToeBoard) == true)
                {
                    Console.WriteLine("Player O won!");
                    break;
                }
            }
        } // end Main( )

        public static void PrintBoard(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void Play(char[,] board, char player)
        {
            int row = 3;
            int col = 3;
            while (row < 0 || row > 2)
            {
                Console.Write($"Player '{player}' row: ");
                row = int.Parse(Console.ReadLine());
            }
            while (col < 0 || col > 2)
            {
                Console.Write($"Player '{player}' col: ");
                col = int.Parse(Console.ReadLine());
            }
            if(board[row,col] == 'X' || board[row,col] == 'O')
            {
                Console.WriteLine("That spot is already taken. Please choose a different one.");
                Play(board, player);
            }
            else
            {
                board[row, col] = player;
                PrintBoard(board);
            }
        }

        public static bool DidPlayerWin(char[,] board)
        {
            if (board[0,0] == 'X' && board[0,1] == 'X' && board[0,2] == 'X')    // Top Across
            {
                return true;
            }
            if (board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O') // Top Across
            {
                return true;
            }
            if (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X')    // Mid Across
            {
                return true;
            }
            if (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O') // Mid Across
            {
                return true;
            }
            if (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X')    // Bottom Across
            {
                return true;
            }
            if (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O') // Bottom Across
            {
                return true;
            }
            if (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X') // Left Down
            {
                return true;
            }
            if (board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O') // Left Down
            {
                return true;
            }
            if (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X') // Mid Down
            {
                return true;
            }
            if (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O') // Mid Down
            {
                return true;
            }
            if (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X') // Right Down
            {
                return true;
            }
            if (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O') // Right Down
            {
                return true;
            }
            if (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X') // Left Diagnol
            {
                return true;
            }
            if (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O') // Left Diagnol
            {
                return true;
            }
            if (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X') // Right Diagnol
            {
                return true;
            }
            if (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O') // Right Diagnol
            {
                return true;
            }
            else return false;
        }
    }
}
