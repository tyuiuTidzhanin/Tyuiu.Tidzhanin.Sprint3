using Tyuiu.Tidzhanin.Sprint3.Task7.V25.Lib;

Console.Title = "Спринт #3 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
Console.WriteLine("* F(x) = cos(x) + 4x/2 - sin(x)*3x                                       *");
Console.WriteLine("* на диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль.    *");
Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine($"Начало диапазона = {startValue}");
Console.WriteLine($"Конец диапазона = {stopValue}");
Console.WriteLine("Функция: F(x) = cos(x) + 4x/2 - sin(x)*3x");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double[] result = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("+----------+-----------+");
Console.WriteLine("|    X     |    F(x)   |");
Console.WriteLine("+----------+-----------+");

int count = 0;
for (int x = startValue; x <= stopValue; x++)
{
    Console.WriteLine("|{0,5}     | {1,8}  |", x, result[count]);
    count++;
}

Console.WriteLine("+----------+-----------+");

Console.ReadLine();