// See https://aka.ms/new-console-template for more information


// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите число");             // Выводим подсказку на экран
string inputString = Console.ReadLine();        // Получаем введенную строку с консоли
int value = Convert.ToInt32(inputString);       // Преобразуем к целому типу

int square = value * value;                     // Вычисляем квадрат числа
Console.WriteLine(square);                      // Выводим результат на экран
