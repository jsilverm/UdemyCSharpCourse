using System;

namespace JaggedArrayOfTwoDimensionalArraysExercise
{
    class Program
    {
// when I was a kid, we didn't have C# or jagged arrays, at home I didn't even have 2-d arrays!
// but we had stuff like that -- here's how we would have printed them out!
        static void Main(string[] args)
        {
            Console.WriteLine("This program makes and displays a jagged array of 2-d int arrays!");
            int[][,] jaggedArrayOf2DArrays = new int[3][,];
            jaggedArrayOf2DArrays[0] = new int[,] { { 2, 4, 6 }, { 8, 10, 12 } };
            jaggedArrayOf2DArrays[1] = new int[,] { { 1, 3, 5 }, {7, 9, 11 }, {13, 15, 17 } };
            jaggedArrayOf2DArrays[2] = new int[,] { { 20, 40 }, { 60, 80 }, {100, 120 },
                {200, 400 } };

            Console.WriteLine("Let's print 'em out!");

            for (int majorRow = 0; majorRow != jaggedArrayOf2DArrays.GetLength(0); ++majorRow)
            {
                Console.WriteLine($"2-d array #{majorRow}:");
                Console.WriteLine("{ ");
                int lastRow = jaggedArrayOf2DArrays[majorRow].GetLength(0) - 1;
                for (int i = 0; i <= lastRow; ++i)
                {
                    Console.Write("\t{ ");
                    int lastCol = jaggedArrayOf2DArrays[majorRow].GetLength(1) - 1;
                    for (int j = 0; j <= lastCol; j++)
                    {
                        Console.Write(jaggedArrayOf2DArrays[majorRow][i,j] );
                        if (j != lastCol) Console.Write(", ");
                    }
                    Console.Write(" }");
                    if (i != lastRow) Console.WriteLine(",");
                }
                Console.WriteLine();
                Console.WriteLine("}");

            }
            Console.WriteLine("Hit ENTER when done admiring");
            Console.ReadLine();

        }
    }
}
