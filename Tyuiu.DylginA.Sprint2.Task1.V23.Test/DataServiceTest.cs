using Tyuiu.DylginA.Sprint2.Task1.V23.Lib;
namespace Tyuiu.DylginA.Sprint2.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //a = 242, b = 571, c = 325, d = 155
            //False, False, False, True, True, True
            DataService ds = new DataService();
            int a = 242;
            int b = 571;
            int c = 325;
            int d = 155;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, false, true, true, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}