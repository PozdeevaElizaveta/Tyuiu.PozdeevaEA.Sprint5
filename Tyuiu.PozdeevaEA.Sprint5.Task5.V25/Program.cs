using Tyuiu.PozdeevaEA.Sprint5.Task5.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл, в котором есть набор значений. Найти произведение всех        *");
        Console.WriteLine("* вещественных чисел в файле. Результат округлить до 3 знаков после       *");
        Console.WriteLine("* запятой и вернуть полученный результат на консоль.                      *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\Users\lpozd\source\repos\Tyuiu.PozdeevaEA.Sprint5\Tyuiu.PozdeevaEA.Sprint5.Task5.V25\bin\Debug\net8.0\InPutDataFileTask5V25.txt";
        Console.WriteLine("Исходный файл с данными: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("Произведение элементов файла" + res);

        Console.ReadKey();
    }
}