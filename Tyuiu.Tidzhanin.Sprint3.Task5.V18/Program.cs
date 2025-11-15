using Tyuiu.Tidzhanin.Sprint3.Task5.V18.Lib;

Console.Title = "Спринт #3 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Вложенные циклы                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Вычислить двойную сумму по формуле при x=5:                             *");
Console.WriteLine("*     3      11                                                           *");
Console.WriteLine("* y = ∑    ∑   (cos(x) + k²/2)                                            *");
Console.WriteLine("*    i=1   k=1                                                            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 5;
int startValue1 = 1;
int stopValue1 = 3;
int startValue2 = 1;
int stopValue2 = 11;

Console.WriteLine($"X = {x}");
Console.WriteLine($"Начало внешней суммы (i) = {startValue1}");
Console.WriteLine($"Конец внешней суммы (i) = {stopValue1}");
Console.WriteLine($"Начало внутренней суммы (k) = {startValue2}");
Console.WriteLine($"Конец внутренней суммы (k) = {stopValue2}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

Console.WriteLine($"Результат = {result:F5}");

Console.ReadLine();