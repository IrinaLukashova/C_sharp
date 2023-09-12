/* 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. */
void PrintNaturalRowFromMToN(int m, int n)
{
    if (m <= n)
    {
        System.Console.Write(m + " ");
        PrintNaturalRowFromMToN(m+1,n);
    }
}

PrintNaturalRowFromMToN(1,7);