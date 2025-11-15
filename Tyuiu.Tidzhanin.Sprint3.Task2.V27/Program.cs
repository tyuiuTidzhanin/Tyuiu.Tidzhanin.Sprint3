using Tyuiu.Tidzhanin.Sprint3.Task2.V27.Lib;

Console.Title = "Спринт #3 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла do...while                                         *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #27                                                             *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму   *");
Console.WriteLine("* ряда по формуле, при x=5:                                               *");
Console.WriteLine("*     14                                                                  *");
Console.WriteLine("* S = ∑ (4/(1 + xⁱ))ⁱ                                                     *");
Console.WriteLine("*    i=1                                                                  *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 5;
int startValue = 1;
int stopValue = 14;

Console.WriteLine($"X = {x}");
Console.WriteLine($"Начальное значение i = {startValue}");
Console.WriteLine($"Конечное значение i = {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.GetSumSeries(x, startValue, stopValue);

Console.WriteLine($"Сумма ряда = {result:F5}");

Console.ReadLine();