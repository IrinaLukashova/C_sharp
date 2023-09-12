/* 69. Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии. */

int Power (int basic, int degree)
{
    if (degree == 0) return 1;
    else return basic*Power(basic, degree - 1);
}

System.Console.WriteLine(Power(16,2));