using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Tidzhanin.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                try
                {
                    double fx = Math.Cos(x) + (4 * x) / 2 - Math.Sin(x) * 3 * x;
                    valueArray[count] = Math.Round(fx, 2);
                }
                catch
                {
                    valueArray[count] = 0;
                }
                count++;
            }

            return valueArray;
        }
    }
}