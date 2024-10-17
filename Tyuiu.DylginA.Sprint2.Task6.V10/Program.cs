using Tyuiu.DylginA.Sprint2.Task6.V10.Lib;
namespace Tyuiu.DylginA.Sprint2.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2");
            Console.WriteLine("* Тема: Получение результата из Switch");
            Console.WriteLine("* Задание #6");
            Console.WriteLine("* Вариант #10");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Дата некоторого дня характеризуется тремя натуральными числами: " +
                "g (год), m (порядковый номер месяца) и n (число). " +
                "'По заданным g, n и m определить дату предыдущего дня. Заданный год не является високосным.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.FindDateOfPreviousDay(g,n,m));
        }
    }
}
