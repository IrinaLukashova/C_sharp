/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
int[] GetRandomArray(int length)
{
    int[] arrayrandom = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayrandom[i] = new Random().Next(100, 1000);
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
    System.Console.WriteLine($"{array[array.Length - 1]}]");
}

System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(size);
PrintArray(userArray);

int EvenInArray(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            number++;
        }
    }
    return number;
}

System.Console.WriteLine($"В введеном массиве {EvenInArray(userArray)} четных элементов");
