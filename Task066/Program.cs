/* 
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumNaturalRowFromMToN(int m, int n)
{
    int sum = 0;
    if (m <= n)
    {
       sum = m + SumNaturalRowFromMToN(m+1,n);
    }
    return sum;
}
System.Console.WriteLine(SumNaturalRowFromMToN(15,5));