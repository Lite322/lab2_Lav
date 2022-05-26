using System;

namespace lab2_Lav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для нахождения суммарного и среднего объёма n-ого колличества шаров с радиусами r, r + 0.2, r + 0.4, r + 0.6,...");
            Console.WriteLine("Задайте коллечество шаров:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте начальный радиус:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Суммарный объём:");
            Console.WriteLine(Volume.Sum(n, r));
            Console.WriteLine("Средний объём:");
            Console.WriteLine(Volume.Average(n, r));
            Console.ReadLine();


        }
    }
}
