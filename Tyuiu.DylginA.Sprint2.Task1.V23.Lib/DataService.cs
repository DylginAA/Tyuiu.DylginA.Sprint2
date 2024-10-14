using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DylginA.Sprint2.Task1.V23.Lib
{
    public class DataService : ISprint2Task1V23

    {
        //a = 242, b = 571, c = 325, d = 155
        //False, False, False, True, True, True
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (c < d);
            res[1] = (a > b) & (c < d);
            res[2] = (a > b) || (c < d);
            res[3] = (a +600 > b) && (c - 300 < d);
            res[4] = !(!res[3]);
            res[5] = (a > b) ^ (c < d+300);
            return res;
        }
    }
}
