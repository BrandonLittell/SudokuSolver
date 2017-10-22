using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver
{
    public class Board
    {
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