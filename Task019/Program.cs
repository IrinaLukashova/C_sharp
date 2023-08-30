/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numbercopy = number;
int reverse = 0;

if (number < 100000 && number > 9999)
{
    for (int i = 10; i <= 100000; i = i * 10)
    {
        int temp = numbercopy % 10;
        numbercopy = (numbercopy - temp) / 10;
        reverse = reverse + temp * 100000 / i;
    }
    Console.WriteLine($"Обратное число равно {reverse}");
}
else 
Console.WriteLine("Число не пятизначное!");

if (number == reverse)
{
    Console.WriteLine($"Число {number} палиндром");
}
else Console.WriteLine($"Число {number} НЕ палиндром");
