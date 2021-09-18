using System;

namespace Davai_posmotrim
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в программу по высчитыванию D и L из S.");
            Console.WriteLine();    
            Console.Write("Пожалуйста, введите площадь круга: ");

            double S = double.Parse(Console.ReadLine());

            double D = Math.Round(Math.Sqrt((4 * S) / 3.14), 3);
            double L = Math.Round(3.14 * D, 3);

            Console.WriteLine();
            Console.WriteLine("Произведя наиточнейшие расчеты, мы получили:");
            Console.WriteLine("     Диаметр данной окружности равен: " + D);
            Console.Write("     Длина данной окружности равена: " + L);
            string a = Console.ReadLine();
        }
    }
}
