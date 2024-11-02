using Tyuiu.NovikAA.Sprint3.Task0.V10.Lib;

Console.Title = "Спринт #3 | Выполнил: Новиков А. А. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Новиков Александр Андреевич | РППб-24-1                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)         *");
Console.WriteLine("* ) и и логических операций (|, &, ||, &&, !, ^)                          *");
Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
Console.WriteLine("* (False, False, False, True, True, True)                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* a = 242, b = 571, c = 325, d = 155                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int start = 1;
int end = 5;
int value = 5;
double result = 0;

DataService DS = new();

result = DS.GetMultiplySeries(value, start, end);

Console.WriteLine(result);