﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            double b;
            b = Math.Sqrt(a);
            if (a <= 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Значение X должно быть положительным"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            Console.WriteLine("{0:F4}", b);
        }
    }
}
