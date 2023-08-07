/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели: ");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday >0 && weekday<6) Console.WriteLine("Сегодня не выходной!");
else if (weekday>5 && weekday<8) Console.WriteLine("Сегодня выходной!");
else Console.WriteLine("Нет такого дня недели!");