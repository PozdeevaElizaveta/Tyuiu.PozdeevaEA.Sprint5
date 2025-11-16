using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PozdeevaEA.Sprint5.Task0.V18.Lib
{
    public class DataService : ISprint5Task0V18
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();
            double y = (double)x / (Math.Pow(Math.Pow(x, 2.0) + x, 0.5));
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
