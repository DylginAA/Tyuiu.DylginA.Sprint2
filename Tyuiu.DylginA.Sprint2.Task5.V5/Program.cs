using Tyuiu.DylginA.Sprint2.Task5.V5.Lib;
namespace Tyuiu.DylginA.Sprint2.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2");
            Console.WriteLine("* Тема: Оператор Switch");
            Console.WriteLine("* Задание #5");
            Console.WriteLine("* Вариант #5");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства: " +
                "«валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14. Порядковые номера остальных карт соответствуют их названиям («шестерка», «девятка» и т. п.). " +
                "По заданному номеру карты k (6 <=k <= 14) определить достоинство соответствующей карты.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Введите K:");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.FindCardValue(value));
        }
    }
}
