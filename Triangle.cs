using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛАБ2_2
{
    internal class Triangle
    {
        private double a, b, c;

        // Конструктор
        public Triangle(double sideA, double sideB, double sideC)
        {
            a = sideA;
            b = sideB;
            c = sideC;
        }

        // Метод для проверки существования треугольника
        public bool Exists()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        // Перегрузка оператора == для сравнения треугольников
        public static bool operator ==(Triangle t1, Triangle t2)
        {
            return t1.a == t2.a && t1.b == t2.b && t1.c == t2.c;
        }

        // Перегрузка оператора != для сравнения треугольников
        public static bool operator !=(Triangle t1, Triangle t2)
        {
            return !(t1 == t2);
        }

        // Переопределение ToString()
        public override string ToString()
        {
            return $"Стороны треугольника: a = {a}, b = {b}, c = {c}";
        }

        // Переопределение Equals и GetHashCode
        public override bool Equals(object obj)
        {
            if (obj is Triangle other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (a, b, c).GetHashCode();
        }
    }
}
