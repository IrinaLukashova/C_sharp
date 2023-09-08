/* 59. Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец,
 на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 25 9 2 38 4 2 45 2 6 7Наименьший элемент - 1, на выходе получим следующий массив:9 4 22 2 63 4 7
 */

 
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

int[] CoordinatesForMin(int[,] array)
{
    int[] coords = {0,0};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < array[coords[0],coords[1]]) 
            {
                coords[0] = i;
                coords[1] =j;
            }
        }
    }
    return coords;
}

void DeliteCross(int[,] array)
{
    int[] cross = CoordinatesForMin(array);
    for (int i = 0; i < array.GetLength(0)-1; i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            if (i < cross[0] && j < cross[1]) Console.Write($"{array[i, j]}\t");
            else if (i < cross[0] && j >= cross[1]) Console.Write($"{array[i, j+1]}\t");
            else if (i >= cross[0] && j < cross[1]) Console.Write($"{array[i+1, j]}\t");
            else Console.Write($"{array[i+1, j+1]}\t");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(int[] array)

{
    System.Console.Write("Координаты минимума:\t");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t ");
    }
    System.Console.WriteLine();
}


int[,] userArray = GetRandom2DArray(3,3,10);
Print2DArray(userArray);
PrintArray(CoordinatesForMin(userArray));
DeliteCross(userArray);
