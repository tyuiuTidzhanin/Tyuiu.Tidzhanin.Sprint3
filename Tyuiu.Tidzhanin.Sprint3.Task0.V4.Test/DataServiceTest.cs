using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint3.Task0.V4.Lib;

namespace Tyuiu.Tidzhanin.Sprint3.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 7;
            double result = ds.GetMultiplySeries(startValue, stopValue);

            // Правильное вычисление ожидаемого результата: ∏(sin(0.1) + k) для k от 1 до 7
            double sinValue = System.Math.Sin(0.1);
            double expected = 1.0;

            for (int k = startValue; k <= stopValue; k++)
            {
                expected *= (sinValue + k);
            }

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}