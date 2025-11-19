using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PozdeevaEA.Sprint5.Task1.V26.Lib
{
    public class DataService : ISprint5Task1V26
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();
            for (double x = startValue; x <= stopValue; x++)
            {
                double y = (((2 * x + 6)/(Math.Cos(x) + x))-3);
                y = Math.Round(y, 2);
                if (x != stopValue)
                {
                    File.AppendAllText(path, Convert.ToString(y) + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, Convert.ToString(y));
                }
            }
            return path;
        }
    }
}
