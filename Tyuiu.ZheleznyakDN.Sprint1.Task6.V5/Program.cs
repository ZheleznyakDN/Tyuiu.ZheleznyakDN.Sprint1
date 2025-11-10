using Tyuiu.ZheleznyakDN.Sprint1.Task6.V5.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint1.Task6.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Железняк Д.Н. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Железняк Дамир Николаевич | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать те слова,     *");
            Console.WriteLine("* которые являются симметричными (например: казак, шалаш).                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            string result = ds.CheckSymmetricalWords(text);

            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("В тексте нет симметричных слов");
            }
            else
            {
                Console.WriteLine($"Симметричные слова: {result}");

                Console.ReadKey();
            }
        }
    }
}
