/* 51. Задайте двумерный массив. Найдите сумму элементов,
 находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. */
int[,] GetRandom2DArray(int rowNumber, int min, int max)
{
    int[,] result = new int[rowNumber, rowNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < rowNumber; j++)
        {
            result[i, j] = new Random().Next(min, max);
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
            Console.Write($"{arrayToPrint[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int Trace(int[,] array)
{
    int trace = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        trace += array[i,i];
    }
    return trace;
}

int[,] userArray = GetRandom2DArray(5,0,11);
Print2DArray(userArray);
System.Console.WriteLine($"След матрицы равен {Trace(userArray)}");