using System;
using System.Collections.Generic;
using SudokuSolver;

namespace SudokuSolver.Cmd
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
