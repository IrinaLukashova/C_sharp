/*
26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Quantity(int number)
{
    int count = 0;
    while (number > 0)
    {
        count = count + 1;
        number = number / 10;
    }
    return count;
}
System.Console.WriteLine($"Количество цифр в числе {number} равно {Quantity(number)}");