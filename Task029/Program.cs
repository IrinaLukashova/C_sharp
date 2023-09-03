/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] GetRandomArray(int length, int start, int end)
{
    int[] arrayrandom = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayrandom[i] = new Random().Next(start,end);
    }
    return arrayrandom;
}

System.Console.WriteLine("Введите размер желаемого массива: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите диапазон, из которого будут выбираться значения массива: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandomArray(size, min, max);

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
PrintArray(userArray);

