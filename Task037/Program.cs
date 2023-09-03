/* найдите произведение пар массива. Парой считаются первый и последний, второй и предпоследний и тд
*/
Console.Clear();
int[] GetRandomArray(int length, int min, int max)
{
    int[] arrayrandom = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayrandom[i] = new Random().Next(min, max + 1);
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
System.Console.WriteLine("Введите верхнюю и нижнюю границу");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(size, min, max);
PrintArray(userArray);

int[] ArrayProduct(int[] array)
{
    int length = 0;
    if (array.Length % 2 == 0)
    {
        length = array.Length / 2;
    }
    else length = array.Length / 2 + 1;

    int[] arrayprod = new int[length];

    for (int i = 0; i < array.Length / 2; i++)
    {
        arrayprod[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) 
    {
        System.Console.WriteLine(true);
        arrayprod[length - 1] = array[length - 1];
    }
    return arrayprod;
}

PrintArray(ArrayProduct(userArray));