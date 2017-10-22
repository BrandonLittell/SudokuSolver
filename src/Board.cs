using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver
{
    public class Board
    {
        public static int[] IndexTest = {
            00, 01, 02, 03, 04, 05, 06, 07, 08,
            09, 10, 11, 12, 13, 14, 15, 16, 17,
            18, 19, 20, 21, 22, 23, 24, 25, 26,
            27, 28, 29, 30, 31, 32, 33, 34, 35,
            36, 37, 38, 39, 40, 41, 42, 43, 44,
            45, 46, 47, 48, 49, 50, 51, 52, 53,
            54, 55, 56, 57, 58, 59, 60, 61, 62,
            63, 64, 65, 66, 67, 68, 69, 70, 71,
            72, 73, 74, 75, 76, 77, 78, 79, 80
        };

        private int[] _board;

        public Board(int[] board)
        {
            _board = board;
        }

        public IEnumerable<int> GetRow(int index)
        {
            var row = index / 9;
            var startIndex = row * 9;
            return _board.Skip(startIndex).Take(9);
        }

        public IEnumerable<int> GetColumn(int index)
        {
            var column = index % 9;
            return _board.Where((n, i) => i % 9 == column);
        }

        public IEnumerable<int> GetSquare(int index)
        {
            var square = SquareId(index);
            return _board.Where((n, i) => SquareId(i) == square);

            int SquareId(int i)
                => (i / 9 / 3 * 3) + (i % 9 / 3);
        }

        public IEnumerable<int> GetPossibleValues(int index)
        {
            var possibleValues = Enumerable.Range(1, 9).ToList();
            var foundValues = GetRow(index).Concat(GetColumn(index).Concat(GetSquare(index))).Distinct();
            return possibleValues.Except(foundValues);
        }

        public IEnumerable<int> Solve()
        {
            int[] prevBoard;
            do
            {
                prevBoard = (int[])_board.Clone();
                for (var i = 0; i < 81; i++)
                {
                    if (_board[i] != -1) continue;
                    var possibleValues = GetPossibleValues(i);
                    if (possibleValues.Count() == 1)
                        _board[i] = possibleValues.First();
                }
            }
            while(!_board.SequenceEqual(prevBoard));

            return _board;
        }
    }
}