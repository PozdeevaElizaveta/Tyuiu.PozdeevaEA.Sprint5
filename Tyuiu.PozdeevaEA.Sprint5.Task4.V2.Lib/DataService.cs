using System.Globalization;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PozdeevaEA.Sprint5.Task4.V2.Lib
{
    public class DataService : ISprint5Task4V2
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX, CultureInfo.InvariantCulture);
            double res = Math.Round((Math.Cos(x) + 3 * x) / (0.25 * x) + 4 - 2.1 * x, 3);
            return res;
        }
    }
}
