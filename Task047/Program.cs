/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

 Console.Clear();

 double[,] GetRandom2DArray(int rowNumber, int columnNumber, int min, int max)
 {
    double[,] result = new double[rowNumber,columnNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < columnNumber; j++)
        {
            result[i,j] = Math.Round(new Random().NextDouble()*(max - min) + min,1);
            //result[i,j] = Math.Round(arrayrandom[i],2);
        }
    }
    return result;
 }

 void Print2DArray(double[,] arrayToPrint)
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

 Print2DArray(GetRandom2DArray(5,5,1,10));
