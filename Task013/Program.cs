/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    int number00 = number % 100 ;
    Console.WriteLine((number - number00) % 1000 / 100);
}
else Console.WriteLine("Третьей цифры нет!");
