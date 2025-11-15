using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Tidzhanin.Sprint3.Task4.V15.Lib
{
    public class DataService : ISprint3Task4V15
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue; 
                }

                double y = ((Math.Sin(x) + x) / x) + 0.75;
                product *= y;
            }

            return Math.Round(product, 3);
        }
    }
}