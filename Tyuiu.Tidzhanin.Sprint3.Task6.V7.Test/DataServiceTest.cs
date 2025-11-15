using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint3.Task6.V7.Lib;

namespace Tyuiu.Tidzhanin.Sprint3.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 17;
            int stopValue = 26;
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            int expected = 0;

            for (int num = startValue; num <= stopValue; num++)
            {
                for (int divisor = 1; divisor <= num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        expected += divisor;
                    }
                }
            }

            Assert.AreEqual(expected, result);
        }
    }
}