using Tyuiu.DylginA.Sprint2.Task1.V23.Lib;
namespace Tyuiu.DylginA.Sprint2.Task1.V23
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
            Console.WriteLine("* УСЛОВИЕ:Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении) " +
                "и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений, которая вернет логическую последовательность(массив):" +
                " (False, False, False, True, True, True), при a = 242, b = 571, c = 325, d = 155");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("a = 242");
            Console.WriteLine("b = 571");
            Console.WriteLine("c = 325");
            Console.WriteLine("d = 155");
            int a = 242;
            int b = 571;
            int c = 325;
            int d = 155;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetLogicOperations(a, b,c,d));
        }
    }
}
