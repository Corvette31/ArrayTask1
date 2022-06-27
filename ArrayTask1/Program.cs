using System;

namespace ArrayTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arrayColumns = 5;
            int arryaRows = 5;
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

            for (int i = 0; i < arryaRows; i++)
            {
                sum += array[row, i];
            }

            for (int i = 0; i < arrayColumns; i++)
            {
                productNumbers *= array[i, column];
            }

            Console.WriteLine($"Сумма строки {row + 1} равна : {sum} , произвидение {column + 1} столбца равна: {productNumbers}");
        }
    }
}
