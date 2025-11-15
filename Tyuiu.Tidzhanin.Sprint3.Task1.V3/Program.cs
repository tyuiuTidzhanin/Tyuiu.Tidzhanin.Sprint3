using Tyuiu.Tidzhanin.Sprint3.Task1.V3.Lib;

Console.Title = "Спринт #3 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла while                                              *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
Console.WriteLine("* ряда по формуле:                                                        *");
Console.WriteLine("*     10                                                                  *");
Console.WriteLine("* p = ∏ k / (cos(5) + 1)²                                                 *");
Console.WriteLine("*    k=1                                                                  *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = 1;
int stopValue = 10;

Console.WriteLine($"Начальное значение k = {startValue}");
Console.WriteLine($"Конечное значение k = {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.GetMultiplySeries(startValue, stopValue);

Console.WriteLine($"Произведение ряда = {result:F5}");

Console.ReadLine();