using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DylginA.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (y <= 4 && x >= 0 && (x > 2 || y < Math.Pow(x, 2)))
            {
                res = true;
            }
            else
            {
                res = false;

            }
            return res;
        }
    }
}
