/* 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

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

System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите верхнюю и нижнюю границу");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Какое число хотим искать в массиве?");
int number = Convert.ToInt32(Console.ReadLine());

string FindNumber(int[] array, int number)
{
    bool variable = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) 
        {
            variable = true;
        }
    }
    string text = "нет";
    if (variable == true) text = "да";
    return text;
}

int[] userArray = GetRandomArray(size,min,max);
PrintArray(userArray);
Console.WriteLine(FindNumber(userArray,number));