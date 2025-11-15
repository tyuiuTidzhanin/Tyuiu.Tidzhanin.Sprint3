using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint3.Task2.V27.Lib;

namespace Tyuiu.Tidzhanin.Sprint3.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 14;
            double result = ds.GetSumSeries(value, startValue, stopValue);

            double expected = 0;
            int i = startValue;

            do
            {
                double denominator = 1 + System.Math.Pow(value, i);
                double term = System.Math.Pow(4.0 / denominator, i);
                expected += term;
                i++;
            }
            while (i <= stopValue);

            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}