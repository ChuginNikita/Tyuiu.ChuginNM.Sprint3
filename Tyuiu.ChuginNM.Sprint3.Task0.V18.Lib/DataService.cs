using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChuginNM.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;

            for (int k = startValue; k <= stopValue; k++)
            {
                double baseValue = 2.0 / (Math.Cos(value) + 0.5);
                res *= Math.Pow(baseValue, k);
            }

            return res;
        }
    }
}
