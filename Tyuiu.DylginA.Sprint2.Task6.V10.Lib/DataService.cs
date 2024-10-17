using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DylginA.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n > 1)
            {
                return (n - 1) + "." + m + "." + g;
            }
            else
            {
                m = m - 1;
                if (m == 0)
                {
                    m = 12;
                    g = g - 1;
                }
                int day = m switch
                {
                    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                    4 or 6 or 9 or 11 => 30,
                    2 => 28,
                    _ => throw new ArgumentException("Неверная дата")
                };

                return day + "." + m + "." + g;
            }
            }
    }
}
