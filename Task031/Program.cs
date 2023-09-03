/*
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
*/
Console.Clear();
int[] GetRandomArray()
{
    int[] arrayrandom = new int[12];
    for (int i = 0; i < 12; i++)
    {
        arrayrandom[i] = new Random().Next(-9,9);
    }
    return arrayrandom;
}

void PrintArray(int[] array)

{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (i < array.Length - 1)
        {
            System.Console.Write($"{array[i]}, ");
        }
        else System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine($"{array[array.Length -1]}]");
}

void PositiveNegativeSum(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive = sumPositive + array[i];
        }
        else sumNegative = sumNegative + array[i];

    }
    System.Console.WriteLine($"{sumPositive}, {sumNegative}");
    //System.Console.WriteLine(sumNegative);
}
int[] userArray = GetRandomArray();
PrintArray(userArray);
PositiveNegativeSum(userArray);