/*
Напишите программу, которая по заданному номеру четверти выдает диапазон координат
*/

Console.WriteLine("Введите номер координатной плоскости: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine($"Диапазон возможных значений X > 0, Y > 0");
}
else if (number == 2)
{
    Console.WriteLine($"Диапазон возможных значений X < 0, Y > 0");
}
else if (number == 3)
{
    Console.WriteLine($"Диапазон возможных значений X < 0, Y < 0");
}
else if (number == 4)
{
    Console.WriteLine($"Диапазон возможных значений X > 0, Y < 0");
}
else
{
    Console.WriteLine($"В координатной плоскости только 4 возможные четверти!");
}