using Tyuiu.ZheleznyakDN.Sprint1.Task5.V1.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x1 = 1, y1 = 1, x2 = 4, y2 = 5;
            int wait = 5;
            int res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(wait, res);
        }
    }
}
