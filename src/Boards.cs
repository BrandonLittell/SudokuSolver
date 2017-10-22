using System;

namespace SudokuSolver
{
    public static class Boards
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

        public static int[] IndexTest2 = {
            -1, 04, 07, 03, 02, 05, 06, 09, 08,
            02, 05, 08, 12, 13, 14, 15, 16, 17,
            03, 06, 09, 21, 22, 23, 24, 25, 26,
            04, 28, 29, 30, 31, 32, 33, 34, 35,
            05, 37, 38, 39, 40, 41, 42, 43, 44,
            06, 46, 47, 48, 49, 50, 51, 52, 53,
            07, 55, 56, 57, 58, 59, 60, 61, 62,
            08, 64, 65, 66, 67, 68, 69, 70, 71,
            09, 73, 74, 75, 76, 77, 78, 79, 80
        };

        public static int[] EasyBoard = {
            -1, -1, -1, 03, -1, 09, 08, -1, 07,
            -1, 04, 07, -1, 05, -1, 06, -1, -1,
            -1, 06, -1, 04, 07, -1, -1, -1, 01,
            -1, -1, 05, -1, -1, 08, -1, -1, 03,
            06, -1, -1, -1, 02, -1, -1, -1, 04,
            02, -1, -1, 01, -1, -1, 09, -1, -1,
            09, -1, -1, -1, 08, 03, -1, 01, -1,
            -1, -1, 06, -1, 04, -1, 03, 07, -1,
            07, -1, 02, 09, -1, 06, -1, -1, -1
        };
    }
}