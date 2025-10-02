﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UlukhanovDV.Sprint1.Task7.V21.Lib
{
    public class DataService : ISprint1Task7V21

    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round(((Math.Pow(y, x) / (Math.Cos(x) - x / 3))) + (((Math.Sin(Math.Pow(x, 2)) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y))) * Math.Tan(x * y)), 3); 
            return res;
        }
    }
}
