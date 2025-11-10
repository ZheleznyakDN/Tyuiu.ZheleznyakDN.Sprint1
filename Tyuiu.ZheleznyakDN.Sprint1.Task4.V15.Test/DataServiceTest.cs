using Tyuiu.ZheleznyakDN.Sprint1.Task4.V15.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint1.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.75;
            double y = 0.5;
            double wait = 1; 
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}

