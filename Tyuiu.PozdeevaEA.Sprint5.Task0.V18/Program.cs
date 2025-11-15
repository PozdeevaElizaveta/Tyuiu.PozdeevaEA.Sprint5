using Tyuiu.PozdeevaEA.Sprint5.Task0.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int x = 3;

        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
        Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
        Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Дано выражение:                                                           *");
        Console.WriteLine("*                   x                                                     *");
        Console.WriteLine("*      y(x) =  -----------                x = 3                           *");
        Console.WriteLine("*              /---2------                                                *");
        Console.WriteLine("*             /   x + x                                                   *");


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double y = (double)x / (Math.Pow(Math.Pow(x, 2.0) + x, 0.5));
        y = Math.Round(y, 3);
        Console.WriteLine("Результат " + y);
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан");

        Console.ReadKey();
    }
}