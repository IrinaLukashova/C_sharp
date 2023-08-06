/*
14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите необходимые делители: ");
int divide1 = Convert.ToInt32(Console.ReadLine());
int divide2 = Convert.ToInt32(Console.ReadLine());
if (number % (divide1 * divide2) == 0) Console.WriteLine($"Число {number} кратно как {divide1}, так и {divide2}");
else Console.WriteLine("не кратно");