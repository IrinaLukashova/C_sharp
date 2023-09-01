/*
45. Напишите программу, которая будет создавать копию заданного одномерного массива 
с помощью поэлементного копирования.
*/

int[] array = {1, 2, 3, 4, 8};

int[] ArrayCopy(int[] array)
{
    int[] newarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newarray[i] = array[i];
    }
    return newarray;
}

void PrintArray(int [] arrayToPrint)
{
    Console.Write("[");
    for (int i=0; i<arrayToPrint.Length; i++)
    {
       Console.Write(arrayToPrint[i]);
       if (i<arrayToPrint.Length - 1)
       {
        Console.Write (", ");
       }
    }
    Console.WriteLine("]");
}
PrintArray(array);
PrintArray(ArrayCopy(array));