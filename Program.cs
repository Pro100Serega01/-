using System;
namespace ЛАБ2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Basic_Class basic = new Basic_Class(true, false);
            Console.WriteLine(basic.ToString());
            Console.WriteLine($"Конъюнкция: {basic.CalculateConjunction()}");

            Dother_Class дочерний = new Dother_Class(true, true, "ДочернийКласс");
            Console.WriteLine(дочерний.GetInfo());
            Console.WriteLine($"Конъюнкция: {дочерний.CalculateConjunction()}");
        }
    }
}