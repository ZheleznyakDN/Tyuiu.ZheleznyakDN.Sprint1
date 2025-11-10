using Tyuiu.ZheleznyakDN.Sprint1.Task6.V5.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string text = "Казак! Шалаш? Доход, мадам.";
            string wait = "Казак, Шалаш, Доход, мадам";
            string res = ds.CheckSymmetricalWords(text);
            Assert.AreEqual(wait, res);
        }
    }
}
