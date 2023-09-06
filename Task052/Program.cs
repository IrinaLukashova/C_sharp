/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

void PrintArray(double[] array)

{
    System.Console.Write("mean:\t");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t ");
    }
    System.Console.WriteLine();
}

double[] MeanInColumnArray(int[,] array)
{
    double[] meanInColumn = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            meanInColumn[i] =meanInColumn[i] + array[j,i];
        }
        meanInColumn[i] = Math.Round(meanInColumn[i]/array.GetLength(0),1);
    }
    return meanInColumn;
}

System.Console.WriteLine("Введите число строк и столбцов в массиве:");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int[,] userArray = GetRandom2DArray(rows,columns,10);
Print2DArray(userArray);
PrintArray(MeanInColumnArray(userArray));
