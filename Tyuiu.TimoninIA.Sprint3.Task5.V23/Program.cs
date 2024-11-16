using Tyuiu.TimoninIA.Sprint3.Task5.V23.Lib;

Console.Title = "Спринт #3 | Выполнил: Тимонин И. А. | ИИПБ-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Вложенные циклы                                                *");
Console.WriteLine("* Задание #5                                                           *");
Console.WriteLine("* Вариант #23                                                          *");
Console.WriteLine("* Выполнил: Тимонин Иван Александрович | ИИПБ-24-1                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

DataService ds = new();
Console.WriteLine(ds.GetSumSumSeries(2, 1, 1, 3, 10));
Console.ReadLine();