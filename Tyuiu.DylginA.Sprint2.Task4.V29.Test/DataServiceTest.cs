using Tyuiu.DylginA.Sprint2.Task4.V29.Lib;
namespace Tyuiu.DylginA.Sprint2.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double z = ds.Calculate(x, y);
            double wait = 8.6;
            Assert.AreEqual(z, wait);

        }
    }
}