﻿using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.NovikAA.Sprint3.Task0.V10.Lib
{
    public class DataService : ISprint3Task0V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;
            for (int i = startValue; i < stopValue +1; i++)
            {
                result *= Math.Pow(300 / (i + Math.Pow(value, i)), i);
            }
            result = Math.Round(result, 3);

            return result;
        }
    }
}
