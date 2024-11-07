using Tyuiu.TimoninIA.Sprint3.Task1.V1.Lib;
namespace Tyuiu.TimoninIA.Sprint3.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Тимонин И. А. | ИИПБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                *");
            Console.WriteLine("* Тема: Оператор цикла while                                                                *");
            Console.WriteLine("* Задание #1                                                                               *");
            Console.WriteLine("* Вариант #1                                                                               *");
            Console.WriteLine("* Выполнил: Тимонин Иван Александрович | ИИПБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу используя цикл while,                                                 *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле.                                          *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int startValue = 1;
            int stopValue = 7;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(startValue, stopValue));

            Console.ReadKey();
        }
    }
}