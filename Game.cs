using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class Game
    {
        private Board board;
        private Player playerX, playerO;
        public Game()
        {
            board = new Board();
            playerX = new Player('X');
            playerO = new Player('O');
        }
        public void StartTheGame()
        {
            Player currentPlayer = playerX;

            while (true)
            {
                board.PrintBoard();

                // ход на играча
                currentPlayer.MakeMove(board);

                char winner = board.CheckWinner();

                //има победител, извежда го и прекратява играта
                if (winner != ' ')
                {
                    Console.WriteLine("Player {0} wins!", winner);
                    break;
                }

                // дали дъската е пълна
                if (board.IsFullBoard())
                { 
                    Console.WriteLine("It's a tie!");
                    break;
                }

                // сменяме текущия играч
                if (currentPlayer == playerX)
                {
                    currentPlayer = playerO;
                }

                else
                {
                   currentPlayer = playerX;
                }
            }

            // Извежда крайното състояние на дъската
            board.PrintBoard();
        }
    }
}

