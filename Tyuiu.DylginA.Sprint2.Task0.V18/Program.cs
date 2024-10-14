using Tyuiu.DylginA.Sprint2.Task0.V18.Lib;
namespace Tyuiu.DylginA.Sprint2.Task0.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2");
            Console.WriteLine("* Тема: Базовые навыки работы в C#");
            Console.WriteLine("* Задание #0");
            Console.WriteLine("* Вариант #18");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) " +
                "и арифметических выражений, которая вернет логическую последовательность(массив): (False, True, True, True, True, False), " +
                "при x = 5105, y = 475");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("x = 5105");
            Console.WriteLine("x = 475");
            int x  = 5105;
            int y = 475;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetCompareOperations(x,y));
        }
    }
}
