using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PozdeevaEA.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);
            StringBuilder result = new StringBuilder();
            foreach (char c in content)
            {
                if (c >= 'а' && c <= 'я')
                {
                    result.Append(char.ToUpper(c));
                }
                else
                {
                    result.Append(c);
                }
            }

            string transformedText = result.ToString();

            string outputPath = @"C:\DataSprint5\OutPutDataFileTask7V12.txt";
            File.WriteAllText(outputPath, transformedText);

            return transformedText;
        }
    }
}
