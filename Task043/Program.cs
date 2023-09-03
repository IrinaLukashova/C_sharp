/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

System.Console.WriteLine($"Введите параметры k1 и b1 первой прямой y = k1 * x + b1");
double k1 = Convert.ToInt32(Console.ReadLine());
double b1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Введите параметры k2 и b2 первой прямой y = k2 * x + b2");
double k2 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());

double[] PointCross(double tg1, double var1, double tg2, double var2)
{
    double abscisa = (var2 - var1)/(tg1 - tg2);
    double ordinata = tg1 * abscisa + var1;
    double[] point = {abscisa,ordinata};
    return point;
}
void PrintArray(double[] array)

{
    System.Console.Write("(");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (i < array.Length - 1)
        {
            System.Console.Write($"{array[i]}, ");
        }
        else System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]})");
}

PrintArray(PointCross(k1, b1, k2, b2));