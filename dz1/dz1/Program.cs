using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Введиет площадь круга");
            double S = double.Parse(Console.ReadLine());
            if (S > 0)
            {
                double D = Math.Sqrt(4 * S / Math.PI);
                double L = Math.PI * D;
                Console.WriteLine($"Диаметр окружноси равен: {D}");
                Console.WriteLine($"Длина окружноси равна: {L}");
            }
            else {
                Console.Write("Некорректная площадь");
            }
            
        }
    }
}
