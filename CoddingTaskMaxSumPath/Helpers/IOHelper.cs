﻿namespace CoddingTaskMaxSumPath
{
    using System;

    internal static class IOHelper
    {
        public static int[][] GetInitDataArray()
        {
            var initData = new int[][]
            {
                new int[] { 215 },
                new int[] { 192, 124 },
                new int[] { 117, 269, 442 },
                new int[] { 218, 836, 347, 235 },
                new int[] { 320, 805, 522, 417, 345 },
                new int[] { 229, 601, 728, 835, 133, 124 },
                new int[] { 248, 202, 277, 433, 207, 263, 257 },
                new int[] { 359, 464, 504, 528, 516, 716, 871, 182 },
                new int[] { 461, 441, 426, 656, 863, 560, 380, 171, 923 },
                new int[] { 381, 348, 573, 533, 448, 632, 387, 176, 975, 449 },
                new int[] { 223, 711, 445, 645, 245, 543, 931, 532, 937, 541, 444 },
                new int[] { 330, 131, 333, 928, 376, 733, 017, 778, 839, 168, 197, 197 },
                new int[] { 131, 171, 522, 137, 217, 224, 291, 413, 528, 520, 227, 229, 928 },
                new int[] { 223, 626, 034, 683, 839, 052, 627, 310, 713, 999, 629, 817, 410, 121 },
                new int[] { 924, 622, 911, 233, 325, 139, 721, 218, 253, 223, 107, 233, 230, 124, 233 },
            };

            return initData;
        }

        public static int[][] GetTestDataArray()
        {
            var initData = new int[][]
            {
                new int[] { 1 },
                new int[] { 8, 9 },
                new int[] { 1, 5, 9 },
                new int[] { 4, 5, 2, 3 },
            };

            return initData;
        }

        public static void LogInitialData(int[][] initData)
        {
            Console.Write("Initial data: \n");

            for (int i = 0; i < initData.Length; i++)
            {
                for (int j = 0; j < initData[i].Length; j++)
                {
                    Console.Write($"{initData[i][j]} ");
                }

                Console.WriteLine();
            }
        }

        public static void LogMaxSumResults(int maxSum, string path)
        {
            Console.WriteLine("\nResults:");
            Console.WriteLine($"MaxSum: {maxSum}");
            Console.WriteLine($"Path: {path}");
        }
    }
}
