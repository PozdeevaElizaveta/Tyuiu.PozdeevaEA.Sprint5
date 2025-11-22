using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PozdeevaEA.Sprint5.Task2.V8.Lib
{
    public class DataService : ISprint5Task2V8
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.GetTempFileName();

            int row = matrix.GetUpperBound(0) +1;
            int col = matrix.Length/ row;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j != col -1)
                    {
                        str = str + matrix[i,j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                    
                }
                if (i != row - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }
            return path;
        }
    }
}
