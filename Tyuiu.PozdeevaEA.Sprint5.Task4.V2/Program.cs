using Tyuiu.PozdeevaEA.Sprint5.Task4.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл, в котором есть вещественное значение. Прочитать значение из   *");
        Console.WriteLine("* файла и подставить вместо Х в формуле. Округлить до трёх знаков после   *");
        Console.WriteLine("* запятой и вернуть полученный результат на консоль.                      *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Формула :      cos(x) + 3x                                              *");
        Console.WriteLine("*            y = ------------ + 4 - 2.1x                                  *");
        Console.WriteLine("*                   0.25x                                                 *");

        string path = @"C:\Users\lpozd\source\repos\Tyuiu.PozdeevaEA.Sprint5\Tyuiu.PozdeevaEA.Sprint5.Task4.V2\bin\Debug\net8.0\InPutDataFileTask4V2.txt";
        Console.WriteLine("Исходный файл с данными: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);

        Console.ReadKey();
    }
}