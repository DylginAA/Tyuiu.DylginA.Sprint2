using Tyuiu.DylginA.Sprint2.Task4.V29.Lib;
namespace Tyuiu.DylginA.Sprint2.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2");
            Console.WriteLine("* Тема: Вложенные операторы");
            Console.WriteLine("* Задание #4");
            Console.WriteLine("* Вариант #29");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Написать программу, которая вычисляет требуемое значение с использование тернарного оператора, " +
                "где пользователь вводит х и у с клавиатуры");
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
            Console.WriteLine(ds.Calculate(x,y));
        }
    }
}
