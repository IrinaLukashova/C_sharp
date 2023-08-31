/*
30. Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
*/

int[] GetRandomArray()
{
    int[] arrayZeroOne = new int[8];
    for (int i = 0; i < arrayZeroOne.Length; i++)
    {
        arrayZeroOne[i] = new Random().Next(0,2);
    }
    return arrayZeroOne;
}

int[] userArray = GetRandomArray();

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine("]");
}
PrintArray(userArray);

