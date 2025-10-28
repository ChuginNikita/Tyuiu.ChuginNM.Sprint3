using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChuginNM.Sprint3.Task7.V13.Lib
{
    public class DataService : ISprint3Task7V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            List<double> mass = new List<double>();

            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Cos(i) + 1 == 0) { mass.Add(0); } else { mass.Add(Math.Round((3 * i + 2 - (2 * i - i) / (Math.Cos(i) + 1)), 2)); }

            }

            double[] results = mass.ToArray();

            return results;
        }
    }
}
