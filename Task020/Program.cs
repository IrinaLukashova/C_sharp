/*
20. Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
*/
Console.WriteLine("Введите кординаты X и Y первой точки: ");
int abscisa1 = Convert.ToInt32(Console.ReadLine());
int ordinata1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординаты X и Y второй точки: ");
int abscisa2 = Convert.ToInt32(Console.ReadLine());
int ordinata2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt((abscisa1 - abscisa2) * (abscisa1 - abscisa2) + (ordinata1 - ordinata2) * (ordinata1 - ordinata2));
Console.WriteLine($"Расстояние между точками равно {Math.Round(distance, 2)}");