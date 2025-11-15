using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint3.Task7.V25.Lib;

namespace Tyuiu.Tidzhanin.Sprint3.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] result = ds.GetMassFunction(startValue, stopValue);

            double[] expected = new double[stopValue - startValue + 1];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                expected[count] = Math.Round(Math.Cos(x) + (4 * x) / 2 - Math.Sin(x) * 3 * x, 2);
                count++;
            }

            CollectionAssert.AreEqual(expected, result);
        }
    }
}