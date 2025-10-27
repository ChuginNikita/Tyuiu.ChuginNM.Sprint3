using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChuginNM.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {

            double S = 0.0;

            for (int k = startValue; k <= stopValue; k++)
            {
                S += 1.0 / (k * k);
                
            }

            return Math.Round(S, 3);
        }
    }
}
