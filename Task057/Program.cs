/* 57. Составить частотный словарь элементов двумерного массива.
 Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */

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

// Разворот матрицы в одномерный массив
int[] ExpandMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0) * matrix.GetLength(1);
    int[] array = new int[n];
    n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[n] = matrix[i, j];
            n++;
        }
    }
    return array;
}

// Сортировка элементов по возрастанию
int[] CollectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        if (i != minPosition)
        {
            int tmp = array[i];
            array[i] = array[minPosition];
            array[minPosition] = tmp;
        }
    }
    return array;
}

void CountElements(int[] array)
{
    
    int count = 0;
    int number = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number) count++;
        else 
        {
            Console.WriteLine($"Число {number} встречается {count} раз");
            number = array[i];
            count = 1;
        }
        if (i == array.Length - 1)
            Console.WriteLine($"Число {number} встречается {count} раз");
    }
    
}

int[,] userArray = GetRandom2DArray(2,3,10);
Print2DArray(userArray);
CountElements(CollectionSort(ExpandMatrix(userArray)));