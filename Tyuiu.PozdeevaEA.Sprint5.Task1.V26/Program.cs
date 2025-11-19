using Tyuiu.PozdeevaEA.Sprint5.Task1.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция:                                                           *");
        Console.WriteLine("*                2x + 6                                                   *");
        Console.WriteLine("*      F(x) =  ----------- - 3                                            *");
        Console.WriteLine("*              cos(x) + x                                                 *");
        Console.WriteLine("* (Произвести табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1. *");
        Console.WriteLine("* Округлить до двух знаков после запятой.                                 *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Дана функция:                                                             *");
        Console.WriteLine("*                2x + 6                                                   *");
        Console.WriteLine("*      F(x) =  -----------                                          *");
        Console.WriteLine("*              cos(x) + x                                                *");
        Console.WriteLine("*             /   x + x                                                   *");


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int startValue = -5;
        int stopValue = 5;
        string res = ds.SaveToFileTextData(startValue, stopValue);
        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан");

        Console.ReadKey();
    }
}