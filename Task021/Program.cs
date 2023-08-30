/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Введите кординаты X, Y и Z первой точки: ");
int abscisa1 = Convert.ToInt32(Console.ReadLine());
int ordinata1 = Convert.ToInt32(Console.ReadLine());
int applicata1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординаты X, Y и Z второй точки: ");
int abscisa2 = Convert.ToInt32(Console.ReadLine());
int ordinata2 = Convert.ToInt32(Console.ReadLine());
int applicata2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((abscisa1 - abscisa2),2) + Math.Pow((ordinata1 - ordinata2),2) + Math.Pow((applicata1 - applicata2),2));
Console.WriteLine($"Расстояние между точками равно {Math.Round(distance, 2)}");