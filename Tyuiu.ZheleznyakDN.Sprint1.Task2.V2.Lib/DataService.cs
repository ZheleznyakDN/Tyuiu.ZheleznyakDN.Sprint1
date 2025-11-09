using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZheleznyakDN.Sprint1.Task2.V2.Lib
{
    public class DataService : ISprint1Task2V2
    {
        public double ConvertAngleToRad(int value)
        {
            double rad = value * Math.PI /180;
            return Math.Round(rad, 3);
        }
    }
}
