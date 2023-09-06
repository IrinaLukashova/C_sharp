/* 49. Задайте двумерный массив. Найдите элементы,
 у которых оба индекса чётные,
 и замените эти элементы на их квадраты */

Console.Clear();

int[,] GetRandom2DArray(int rowNumber, int columnNumber, int deviation)
{
    int[,] result = new int[rowNumber, columnNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < columnNumber; j++)
        {
            result[i, j] = new Random().Next(0, deviation);
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

int[,] PoweredEvenElementsArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
    return array;
}

int[,] userArray = GetRandom2DArray(5, 5, 10);
Print2DArray(userArray);
System.Console.WriteLine();
Print2DArray(PoweredEvenElementsArray(userArray));
