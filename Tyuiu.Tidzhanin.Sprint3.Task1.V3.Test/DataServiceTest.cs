using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint3.Task1.V3.Lib;

namespace Tyuiu.Tidzhanin.Sprint3.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double result = ds.GetMultiplySeries(startValue, stopValue);

            double denominator = System.Math.Pow(System.Math.Cos(5) + 1, 2);
            double expected = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                expected *= k / denominator;
                k++;
            }
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}