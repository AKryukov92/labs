﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
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
            if (a <= 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            b = (5 * Math.Cos(a * Math.PI / 180));
            Console.WriteLine("{0:F4}", b);
        }
    }
}
