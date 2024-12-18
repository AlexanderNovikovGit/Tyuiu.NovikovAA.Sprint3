﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovAA.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double result = 0;
            while (startValue <= stopValue)
            {
                result += ((Math.Pow(value, startValue) + (5 / startValue + 4)) * Math.Sin(value));
                startValue++;

            }
        result = Math.Round(result, 2);
        return result;
        }
    }
}
