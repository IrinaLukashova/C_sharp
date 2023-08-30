/*
Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
*/

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

for (int k = 1; k <= number; k++)
{
    for (int i = 1; i <= 5; i++) 
    {    
        Console.Write($"{k * k} ");
        k = k + 1;
    }
Console.WriteLine("\n");
}