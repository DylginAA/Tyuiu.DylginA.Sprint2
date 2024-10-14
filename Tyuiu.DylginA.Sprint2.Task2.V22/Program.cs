using Tyuiu.DylginA.Sprint2.Task2.V22.Lib;
namespace Tyuiu.DylginA.Sprint2.Task2.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2");
            Console.WriteLine("* Тема: Базовые навыки работы в C#");
            Console.WriteLine("* Задание #2");
            Console.WriteLine("* Вариант #22");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Написать программу на, которая запрашивает целые значения с клавиатуры " +
                "и вычисляет находится ли точка с координатами X,Y в заштрихованной области.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите у:");
            int y = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.CheckDotInShadedArea(x,y));
        }
    }
}
