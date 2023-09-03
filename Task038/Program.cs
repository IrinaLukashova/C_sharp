/*
Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.Clear();
double[] GetRandomArray(int length, int min, int max)
{
    double[] arrayrandom = new double[length];
    for (int i = 0; i < length; i++)
    {

        arrayrandom[i] = new Random().NextDouble() * (max - min) + min;
        arrayrandom[i] = Math.Round(arrayrandom[i],2);
    }
    return arrayrandom;
}

void PrintArray(double[] array)

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

System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите верхнюю и нижнюю границу");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

double[] userArray = GetRandomArray(size,min,max);
PrintArray(userArray);

double MaxMinDifference (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double difference = 0;
    difference = max - min;
    return difference;
}
System.Console.WriteLine(Math.Round(MaxMinDifference(userArray),2));
