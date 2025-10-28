using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChuginNM.Sprint3.Task5.V10.Lib
{
    public class DataService : ISprint3Task5V10
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double mul = 1;
            double mul2 = 1;

            for (int k = startValue1; k <= stopValue1; k++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    mul2 *= (Math.Pow(x, 3) * k + 2);
                }
                mul *= mul2;
            }

            return Math.Round(mul, 3);
        }
    }
}
