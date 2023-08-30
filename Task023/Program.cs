/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

for (int k = 1; k <= number; k++)
{ 
    Console.Write($"{Math.Pow(k,3)} ");
    if (k % 5 == 0) // просто хочу, чтобы была таблица, а не ряд чисел
    {
        Console.WriteLine("\n");
    }
}
Console.WriteLine("\n");


