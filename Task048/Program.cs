/* 48. Задайте двумерный массив размера m на n,
 каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
 Выведите полученный массив на экран. */


 int[,] GetRandom2DArray(int rowNumber, int columnNumber)
 {
    int[,] result = new int[rowNumber,columnNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < columnNumber; j++)
        {
            result[i,j] = i + j;
        }
    }
    return result;
 }

 void Print2DArray(int[,] arrayToPrint)
 {
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
        {
            Console.Write($"[{i}] \t");
        }
        System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}] \t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i,j]}\t");
        }
    Console.WriteLine();
    }
 }

System.Console.WriteLine("Введите число строк и столбцов в матрице");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Print2DArray(GetRandom2DArray(m, n));
