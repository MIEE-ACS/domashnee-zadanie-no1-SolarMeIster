using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            decimal number = decimal.Parse(Console.ReadLine());
            decimal first = number * number; // вторая степень 
            decimal second = first * number; // третья степень
            first = second * first; // пятая степень
            second = first * first; // десятая степень
            second = first * second; // пятнадцатая степень
            Console.WriteLine($"Пятнадцатая степень числа {number}: {second}");
        }
    }
}
