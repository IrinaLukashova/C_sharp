/* 35. Задайте одномерный массив из 123 случайных чисел.
 Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */
Console.Clear();
int[] GetRandomArray(int length, int min, int max)
{
    int[] arrayrandom = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayrandom[i] = new Random().Next(min,max + 1);
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

System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите верхнюю и нижнюю границу");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int CountNumber(int[] array, int downlimit, int uplimit)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= uplimit && array[i] >= downlimit) 
        {
            count = count + 1;
        }
    }
    return count;
}
System.Console.WriteLine("Числа из какого диапазона мы ищем?");
int down = Convert.ToInt32(Console.ReadLine());
int up = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(size,min,max);
PrintArray(userArray);
int quantity = CountNumber(userArray, down,up);
System.Console.WriteLine(quantity);