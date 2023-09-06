/* Задача 50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */


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

string FindTheElement(int[,] array, int rowNumber, int colNumber)
{
    if (rowNumber >= array.GetLength(0)|| colNumber >= array.GetLength(1)) return "нет такого элемента";
    else return $"На месте ({rowNumber}, {colNumber}) стоит элемент {array[rowNumber,colNumber]}";
}

int[,] userArray = GetRandom2DArray(3,4,10);
Print2DArray(userArray);
System.Console.WriteLine("Введите номер строки");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер столбца");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{FindTheElement(userArray,row,column)}");
