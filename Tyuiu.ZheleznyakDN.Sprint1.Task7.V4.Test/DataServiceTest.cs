using Tyuiu.ZheleznyakDN.Sprint1.Task7.V4.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint1.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 10;
            double result = ds.Calculate(x, y);

            Assert.IsFalse(double.IsNaN(result));
            Assert.IsFalse(double.IsInfinity(result));
        }
    }
}
