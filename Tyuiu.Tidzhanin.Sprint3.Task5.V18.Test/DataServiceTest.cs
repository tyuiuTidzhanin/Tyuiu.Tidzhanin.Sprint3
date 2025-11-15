using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint3.Task5.V18.Lib;

namespace Tyuiu.Tidzhanin.Sprint3.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double expected = 0;
            double cosX = System.Math.Cos(x);

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    expected += cosX + (k * k / 2.0);
                }
            }

            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}