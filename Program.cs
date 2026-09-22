using System;
using System.Collections.Generic;

namespace KT_11_Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(3, 4, 5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"=== Фигура: {shape.GetType().Name} ===");
                Console.WriteLine($"Площадь: {shape.Area():F2}");
                Console.WriteLine($"Периметр: {shape.Perimeter():F2}");

                // Безопасная проверка расширенного интерфейса через pattern matching 'is'
                if (shape is IDrawable drawable)
                {
                    Console.WriteLine(drawable.Draw());
                }

                Console.WriteLine();
            }
        }
    }
}