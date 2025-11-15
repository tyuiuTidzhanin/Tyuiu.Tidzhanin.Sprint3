using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint3.Task3.V18.Lib;

namespace Tyuiu.Tidzhanin.Sprint3.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string value = "4n5nvf 56 bgy";
            char item = 'n';
            string result = ds.ReplaceNumOnChar(value, item);

            string expected = "nnnnvf nn bgy";

            Assert.AreEqual(expected, result);
        }
    }
}