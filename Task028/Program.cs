/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
*/

Console.WriteLine("Введите число: ");
int usernumber = Convert.ToInt32(Console.ReadLine());

int Product(int x)
{
    int count = 1;
    int product = 1;
    while (count <= x)
    {
        product = product * count;
        count++;
    }
    return product;
}
System.Console.WriteLine($"Факториал числа {usernumber} равен {Product(usernumber)}");
