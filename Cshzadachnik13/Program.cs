﻿/* Известно значение температуры по шкале Цельсия. Найти соответствующее  значение температуры по шкале: 
а) Фаренгейта; 
б) Кельвина.
Для пересчета по шкале Фаренгейта необходимо исходное значение температуры умножить на 1,8 и к результату прибавить 32, 
а по шкале Кельвина абсолютное значение нуля соответствует 273,15 градуса по шкале Цельсия.
*/
Console.WriteLine("Введите температуру по Цельсию");
double celcium = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{celcium} градусов цельсия равно {(celcium + 273.15):N3} градусов Кельвина и {(celcium * 1.8 + 32):N3} градусов по Фаренгейту");
