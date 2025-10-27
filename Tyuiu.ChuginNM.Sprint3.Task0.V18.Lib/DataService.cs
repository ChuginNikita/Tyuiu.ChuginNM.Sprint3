using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChuginNM.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;
            double baseValue = 2.0 / (Math.Cos(value) + 0.5);
            for (int k = startValue; k <= stopValue; k++)
            {
                res *= Math.Pow(baseValue, k);
            }

            return res;
        }
    }
}
