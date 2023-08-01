/* # Напишите программу, которая будет выдавать название дня недели по заданному номеру.
*/

Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int weekday = Convert.ToInt32(Console.ReadLine());

if (weekday == 1)
{
    Console.WriteLine("Понедельник");
}
else if (weekday == 2)
{
    Console.WriteLine("Вторник");
}
else if (weekday == 3)
{
    Console.WriteLine("Среда");
}
else if (weekday == 4)
{
    Console.WriteLine("Четверг");
}
else if (weekday == 5)
{
    Console.WriteLine("Пятница");
}
else if (weekday == 6)
{
    Console.WriteLine("Суббота");
}
else
{
    Console.WriteLine("Воскресенье");
}