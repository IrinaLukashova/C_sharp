/* 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
 */

void PrintNaturalRow(int n, int first = 1)
{
    if (first <= n)
    {
        System.Console.Write(first);
        PrintNaturalRow(n,first + 1);
    }
}

PrintNaturalRow(7);