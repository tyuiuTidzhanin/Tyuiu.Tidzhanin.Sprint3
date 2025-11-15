using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Tidzhanin.Sprint3.Task1.V3.Lib
{
    public class DataService : ISprint3Task1V3
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiply = 1.0;
            double denominator = Math.Pow(Math.Cos(5) + 1, 2);
            int k = startValue;

            while (k <= stopValue)
            {
                double term = k / denominator;
                multiply *= term;
                k++;
            }

            return Math.Round(multiply, 3);
        }
    }
}