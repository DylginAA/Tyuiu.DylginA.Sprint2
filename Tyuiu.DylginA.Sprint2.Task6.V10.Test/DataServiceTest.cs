using Tyuiu.DylginA.Sprint2.Task6.V10.Lib;
namespace Tyuiu.DylginA.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g =2024;
            int m = 3;
            int n = 1;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = "4.4.2024";
            Assert.AreEqual(wait, res);
        }
    }
}