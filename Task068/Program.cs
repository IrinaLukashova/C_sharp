/* 
Задача 68:
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int AkkermanFunction(int first, int second)
{
    int answer = 0;
    if (first != 0)
    {
        if (second != 0)
        {
            answer = AkkermanFunction(first-1, AkkermanFunction(first, second -1));
        }
        else answer = AkkermanFunction(first - 1, 1);
    }
    else answer = second + 1; 
    return answer;
}
System.Console.WriteLine(AkkermanFunction(3,5));