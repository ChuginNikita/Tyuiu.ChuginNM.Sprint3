using Tyuiu.ChuginNM.Sprint3.Task1.V4.Lib;

namespace Tyuiu.ChuginNM.Sprint3.Task1.V4
{
    class Program
    {
        static void Main(string[] args) 
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Чугин Н. М. | АСОиУб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Чугин Никита Максимович | АСОиУб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл while, которая вычисляет             *");
            Console.WriteLine("* произведение ряда по формуле.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Нет.                                                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(Math.Round(ds.GetSumSeries(1, 10), 3));
        }
    }
}