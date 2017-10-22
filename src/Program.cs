using System;
using System.Collections.Generic;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board(Boards.EasyBoard);
            var solve = board.Solve();
            Console.WriteLine(board);
        }
    }
}
