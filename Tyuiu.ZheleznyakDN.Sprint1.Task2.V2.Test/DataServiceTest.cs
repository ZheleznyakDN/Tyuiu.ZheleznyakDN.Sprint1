using Tyuiu.ZheleznyakDN.Sprint1.Task2.V2.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint1.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 180;
            double wait = 3.142;
            var res = ds.ConvertAngleToRad(value);
            Assert.AreEqual(wait, res);
        }
    }
}
