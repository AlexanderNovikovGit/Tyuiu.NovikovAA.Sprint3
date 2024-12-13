using Tyuiu.NovikovAA.Sprint3.Task1.V30.Lib;

Console.Title = "Спринт #3 | Выполнил: Новиков А. А. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: оператор цикла for                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Новиков Александр Андреевич | РППб-24-1                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
Console.WriteLine("* ряда по формуле, при x = 5                                              *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* x = 5                                                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int start = 1;
int end = 12;
double value = 0.5;
double result = 0;

DataService DS = new();


result = DS.GetSumSeries(value, start, end);

Console.WriteLine(result);