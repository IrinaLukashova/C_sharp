/* 
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/
Console.WriteLine("Введите кординаты X и Y вашей точки: ");
int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());
if (X > 0)
{
    if (Y > 0)
    {
        Console.WriteLine($" точка ({X}, {Y}) находится в первой четверти");

    }
    else if (Y < 0)
        Console.WriteLine($"Точка ({X}, {Y}) находится в четвертой четверти");
}
if (X < 0)
{
    if (Y > 0)
    {
        Console.WriteLine($"Точка ({X}, {Y}) находится во второй четверти");

    }
    else if (Y < 0)
        Console.WriteLine($"Точка ({X}, {Y}) находится в третьей четверти");
}
else 
Console.WriteLine($"Точка ({X}, {Y}) находится на одной из осей");