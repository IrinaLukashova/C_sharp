/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
*/
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int first = number / 100;
int second = number % 10;
Console.WriteLine(first * 10 + second);
