using Tyuiu.ZheleznyakDN.Sprint1.Task5.V1.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Железняк Д.Н. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Железняк Дамир Николаевич | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            double x1, y1, x2, y2;
            Console.WriteLine("Введите координату X первой точки:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y первой точки:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату X второй точки:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y второй точки:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            int result = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между точками ({x1},{y1}) и ({x2},{y2}) = {result}");

            Console.ReadKey();
        }
    }
}
