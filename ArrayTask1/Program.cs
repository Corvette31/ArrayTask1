using System;

namespace ArrayTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arrayColumns = 3;
            int arryaRows = 4;
            int itemMinValue = 1;
            int itemMaxValue = 9;
            int[,] array = new int[arryaRows, arrayColumns];
            int row = 1;
            int column = 0;
            int sum = 0;
            int productNumbers = 1;

            Console.WriteLine("Двумерный массив: ");

            for (int i = 0; i < arryaRows; i++)
            {
                for (int j = 0; j < arrayColumns; j++)
                {
                    array[i, j] = random.Next(itemMinValue, itemMaxValue);
                    Console.Write($"{array[i, j]} ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum += array[row, i];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                productNumbers *= array[i, column];
            }

            Console.WriteLine($"Сумма строки {row + 1} равна : {sum} , произвидение {column + 1} столбца равна: {productNumbers}");
        }
    }
}
