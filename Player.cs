using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class Player
    {
        private char symbol;
        public Player(char symbol)
        {
            this.symbol = symbol;
        }

        // връща символа на играча
        public char GetSymbol()
        {
            return symbol;
        }
        public void MakeMove(Board board)
        {
            // четем координати от конзолата, докато не въведе валидни
            int row, col;
            do
            {
                Console.WriteLine("Player {0}, enter row and column:", symbol);
                row = int.Parse(Console.ReadLine());
                col = int.Parse(Console.ReadLine());
            }
            while (!board.IsValidMove(row, col));

            // Поставя символа на играча на дъската
            board.MakeMove(row, col, symbol);
        }
    }
}

