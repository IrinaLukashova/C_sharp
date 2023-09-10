/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 
   for (int i = 0; i < result.GetLength(1); i++)
    {
        result[0,i] = count;
        count++;
    }
    for (int i = 1; i < result.GetLength(0); i++)
    {
        result[i,result.GetLength(1)-1] = count;
        count++;
    }
    for (int i = result.GetLength(1)-2; i >= 0; i = i-1)
    {
        result[result.GetLength(0)-1,i] = count;
        count++;
    }
    for (int i = result.GetLength(0)-2; i >0; i = i-1)
    {
       result[i,0] = count;
        count++; 
    }  
    return result;*/

int[,] GetSpiral(int size)
{
    int[,] result = new int[size,size];
    int count = 1;
    int var = size;
    int k = (var+1)/2;
    while (k > 0)
    {
        for (int i = size - var; i < var; i++)
        {
            result[size - var,i] = count;
            count++;
        }
        for (int j = size - var + 1; j < var; j++)
        {
            result[j,var -1] = count;
            count++;
        }
        for (int i = var - 2; i >= size - var; i= i -1)
        {
            result[var -1,i] = count;
            count++;
        }
        for (int j = var - 2; j >= size - var +1; j = j-1)
        {
            result[j,size-var] = count;
            count++;
        }
        k -= 1;
        var -= 1;
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

int[,] userArray = GetSpiral(5); // сделала для любого размера спирали
Print2DArray(userArray);