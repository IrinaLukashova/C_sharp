/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers(int number)
{
    int sum = 0;
    for (int i = number; i > 0; i /= 10)
    {
        sum = sum + i % 10;
    }
    return sum;
}
System.Console.WriteLine($"Сумма цифр в числе {number} равна {SumOfNumbers(number)}");
