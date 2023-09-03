/* 32. Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

Console.Clear();
int[] GetRandomArray(int length, int min, int max)
{
    int[] arrayrandom = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayrandom[i] = new Random().Next(min,max);
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

int[] RerversArray(int[] array)
{
    int[] arrayReverse = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayReverse[i] = - array[i];
    }
    return arrayReverse;
}
int size = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandomArray(size,min,max);
PrintArray(userArray);
PrintArray(RerversArray(userArray));