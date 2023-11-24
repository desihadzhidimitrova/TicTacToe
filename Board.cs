using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class Board
    { 
        private char[,] board;

        // инициализираме дъската с празни места 
        public Board()
        {
            board = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   board[i, j] = ' ';
                }
            }
        }
        public bool IsValidMove(int row, int col)
        {
            return row >= 0 
                && row < 3 
                && col >= 0 
                && col < 3 
                && board[row, col] == ' ';
        }
        public void MakeMove(int row, int col, char symbol)
        {
            board[row, col] = symbol;
        }
        public char CheckWinner()
        {
            //хоризонтални редове
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != ' '
                    && board[i, 0] == board[i, 1]
                    && board[i, 1] == board[i, 2])
                {
                    return board[i, 0];
                }
                    
            }
            // вертикални колони
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] != ' '
                    && board[0, j] == board[1, j]
                    && board[1, j] == board[2, j])
                {
                    return board[0, j];
                }
            }
            //диагонали
            if (board[0, 0] != ' '
                && board[0, 0] == board[1, 1]
                && board[1, 1] == board[2, 2])
            { 
                return board[0, 0];
            }

            if (board[0, 2] != ' '
                && board[0, 2] == board[1, 1]
                && board[1, 1] == board[2, 0])
            {
                return board[0, 2]; 
            }
            return ' ';
        }
        public bool IsFullBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                   return false;
                }
            }
            return true;
        }
        public void PrintBoard()
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                    if (j < 2)
                        Console.Write("|");
                }
                Console.WriteLine();
                if (i < 2)
                    Console.WriteLine("  -----");
            }
        }
    }
}
