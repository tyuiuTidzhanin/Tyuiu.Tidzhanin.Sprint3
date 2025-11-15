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

            double expected = Math.Sin(0.1) * Math.Sin(0.2) * Math.Sin(0.3) *
                            Math.Sin(0.4) * Math.Sin(0.5) * Math.Sin(0.6) * Math.Sin(0.7);
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}