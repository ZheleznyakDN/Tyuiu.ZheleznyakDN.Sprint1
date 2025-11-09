using Tyuiu.ZheleznyakDN.Sprint1.Task3.V13.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint1.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double number = 234;
            double wait = 24;
            var res = ds.MultiplyOfDigits(number);
            Assert.AreEqual(wait, res); 
        }
    }
}
