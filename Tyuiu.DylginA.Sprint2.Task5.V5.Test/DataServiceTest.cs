using Tyuiu.DylginA.Sprint2.Task5.V5.Lib;
namespace Tyuiu.DylginA.Sprint2.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 7;
            string wait = "Семерка";
            string res = ds.FindCardValue(value);
            Assert.AreEqual(wait, res);
        }
    }
}