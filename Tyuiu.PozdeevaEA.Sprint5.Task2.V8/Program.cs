using Tyuiu.PozdeevaEA.Sprint5.Task2.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
        Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и    *");
        Console.WriteLine("* вывести на консоль.                                                     *");
        Console.WriteLine("* 9; 4; -6                                                                *");
        Console.WriteLine("* 3; 9; 9                                                                 *");
        Console.WriteLine("* -6; 7; -4                                                               *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int[,] matrix = new int[3, 3] { { 9, 4, -6 }, { 3, 9, 9 }, { -6, 7, -4 } } ;
        int row = matrix.GetUpperBound(0) + 1;
        int col = matrix.Length / row;

        string res = ds.SaveToFileTextData(matrix);
        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан");

        Console.ReadKey();
    }
}