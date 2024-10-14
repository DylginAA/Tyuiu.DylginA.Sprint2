using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DylginA.Sprint2.Task0.V18.Lib
{
    public class DataService : ISprint2Task0V18
    {
        //(==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) и арифметических выражений, которая вернет логическую
        //последовательность(массив): (False, True, True, True, True, False), при x = 5105, y = 475
        public bool[] GetCompareOperations(int x, int y)
        {
            
           bool[] res = new bool[6];
            res[0] = x == y;
            res[1] = x != y;
            res[2] = x<y+4631;
            res[3] = x>y;
            res[4] = x<=y+4630;
            res[5] = x-5000>=y;

            return res;
        }
    }
}
