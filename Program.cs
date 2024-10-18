using System;
using ЛАБ2_2;

class Program
{
    static void Main()
    {
        Triangle triangle1 = new Triangle(3, 4, 5);
        Console.WriteLine(triangle1.ToString());
        Console.WriteLine($"Существование: {triangle1.Exists()}");

        Triangle triangle2 = new Triangle(5, 4, 3);
        Console.WriteLine($"Равенство треугольников: {triangle1 == triangle2}");
    }
}