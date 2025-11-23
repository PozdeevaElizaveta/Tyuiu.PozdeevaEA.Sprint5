internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #7                                                               *");
        Console.WriteLine("* Тема: обавление к решению итоговых проектов по спринту                  *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл, в котором есть набор символьных данных.Заменить все строчные  *");
        Console.WriteLine("* русские буквы на заглавные.Полученный результат сохранить в файл        *");
        Console.WriteLine("* OutPutDataFileTask7V12.txt.                                             *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\Users\lpozd\source\repos\Tyuiu.PozdeevaEA.Sprint5\Tyuiu.PozdeevaEA.Sprint5.Task7.V12\bin\Debug\net8.0\InPutDataFileTask7V12.txt";
        Console.WriteLine("Исходный файл с данными: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.LoadDataAndSave(path);
        Console.WriteLine("Измененный текст: " + res);

        Console.ReadKey();
    }
}