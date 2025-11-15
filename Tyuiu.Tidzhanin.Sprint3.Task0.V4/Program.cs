using Tyuiu.Tidzhanin.Sprint3.Task0.V4.Lib;

Console.Title = "Спринт #3 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла for                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
Console.WriteLine("* ряда по формуле:                                                        *");
Console.WriteLine("*     7                                                                   *");
Console.WriteLine("* p = ∏ sin(0.1 * k)                                                      *");
Console.WriteLine("*    k=1                                                                  *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = 1;
int stopValue = 7;

Console.WriteLine($"Начальное значение k = {startValue}");
Console.WriteLine($"Конечное значение k = {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.GetMultiplySeries(startValue, stopValue);

Console.WriteLine($"Произведение ряда = {result:F5}");

Console.ReadLine();