
using Tyuiu.PozdeevaEA.Sprint5.Task3.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*                          3       2                                      *");
        Console.WriteLine("* Дано выражение F(x)= 6.1x + 0.23x +1.04x, вычислить его значение при    *");
        Console.WriteLine("* x = 3, результат сохранить в бинарный файл и вывести на консоль.        *");
        Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int x = 3;

        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан");

        Console.ReadKey();
    }
}