using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint3.Task4.V15.Lib;

namespace Tyuiu.Tidzhanin.Sprint3.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double result = ds.Calculate(startValue, stopValue);

            double expected = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) continue;

                double y = (System.Math.Sin(x) + x) / x + 0.75;
                expected *= y;
            }

            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}