/*
24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
*/
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
/*
for (int i = 1; i<=A; i++)
{
    sum = sum + i;
}
Console.WriteLine($"Сумма числе от 1 до А равна {sum}");
*/
int SumOfNumbers(int x)
{
    int result = 0;
    for (int i = 1; i <= x; i++)
    {
        result = result + i;
    }
    return result;
}
int sum = SumOfNumbers(A);
Console.WriteLine($"Сумма числе от 1 до А равна {sum}");