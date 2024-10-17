using Tyuiu.DylginA.Sprint2.Task7.V8.Lib;
namespace Tyuiu.DylginA.Sprint2.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2");
            Console.WriteLine("* Тема: Подведение итогов");
            Console.WriteLine("* Задание #7");
            Console.WriteLine("* Вариант #8");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Написать программу на C#, которая запрашивает исходные данные (вещественные значения) " +
                "и вычисляет, находится ли точка с координатами X,Y в заштрихованной области." +
                "'По заданным g, n и m определить дату предыдущего дня. Заданный год не является високосным.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.CheckDotInShadedArea(x,y));
        }
    }
}
