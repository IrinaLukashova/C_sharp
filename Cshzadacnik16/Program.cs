/*Cоставить программу обмена значениями трех переменных величин а, b, c по
следующим двум схемам: 
    а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
    б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
    */

System.Console.WriteLine("Введите три переменные: ");
int varA = Convert.ToInt32(Console.ReadLine());
int varB = Convert.ToInt32(Console.ReadLine());
int varC = Convert.ToInt32(Console.ReadLine());

int tempB = varB;
//int tempA = varA; //часть решения a)
int tempC = varC; //часть решения б)

varB = varA;
varC = tempB;
varA = tempC;
//varB = varC;
//varA = tempB;
//varC = tempA;

Console.WriteLine($"Переменная A равна {varA}, переменная B равно {varB}, C равно {varC}.");

int tempA = varB;

varB = tempC;
varC = tempA;
varA = tempB;
Console.WriteLine($"Переменная A равна {varA}, переменная B равно {varB}, C равно {varC}.");