/*
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.
*/
Console.WriteLine("Введите 2 числа: ");
int TheFirstNumber = Convert.ToInt32(Console.ReadLine());
int TheSecondNumber = Convert.ToInt32(Console.ReadLine());

if (TheSecondNumber % TheFirstNumber == 0) Console.WriteLine($"Число {TheSecondNumber} кратно {TheFirstNumber}");
else 
{
    Console.WriteLine($"Остаток от деления {TheSecondNumber} на {TheFirstNumber} равен {TheSecondNumber % TheFirstNumber}");
}