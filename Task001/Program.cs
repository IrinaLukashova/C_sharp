/* Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
*/
Console.WriteLine("Введите два числа ");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());
if (number_1 == number_2 * number_2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else 
{
    Console.WriteLine("Первое число не квадрат второго");
}
