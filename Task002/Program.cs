/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/
Console.WriteLine("Введите 2 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine(number1 + " - большее число, " + number2 + " - меньшее число.");
}
else if (number1 < number2)
{
    Console.WriteLine(number2 + " - большее число, " + number1 + " - меньшее число.");
}
else 
{
    Console.WriteLine("Числа равны!");
}