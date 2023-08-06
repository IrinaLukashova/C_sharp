/*
16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
*/
Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2* num2 || num2 == num1* num1) Console.WriteLine("Одно число является квадратом другого");
else Console.WriteLine("Числа не являются квадратами друг друга");