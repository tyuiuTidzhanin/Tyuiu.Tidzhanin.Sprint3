using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Tidzhanin.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiply = 1.0;
            double sinValue = Math.Sin(0.1); 

            for (int k = startValue; k <= stopValue; k++)
            {
                double term = sinValue + k;
                multiply *= term;
            }

            return multiply;
        }
    }
}