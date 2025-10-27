using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChuginNM.Sprint3.Task2.V17.Lib
{
    public class DataService : ISprint3Task2V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double S = 0.0;
            int k = startValue;

            do
            {
                S += Math.Pow(1.0 / (Math.Cos(k) + 2), 2);
                k++;
            } while (k <= stopValue);

            return Math.Round(S, 3);
        }
    }
}
