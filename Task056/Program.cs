/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка
 */

 
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

int[] SumRows(int[,] array)
{
    int[] sumarray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumarray[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumarray[i] += array[i,j];
        }
    }
    return sumarray;
}

int Min(int[] array)
{
    int minrow = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minrow]) minrow = i;
    }
    return minrow;
}

int[,] userArray = GetRandom2DArray(5,0,10);
Print2DArray(userArray);
System.Console.WriteLine($"Строка с наименьшей суммой элементов - {Min(SumRows(userArray))}");