﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task26
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            String z;
            z = Console.ReadLine();
            double c;
            c = double.Parse(z);
            String x;
            x = Console.ReadLine();
            double v;
            v = double.Parse(x);
            String w;
            w = Console.ReadLine();
            double e;
            e = double.Parse(w);
            double b;
            b = (a * e) + (c * v) / (a * e) ;
            Console.WriteLine("{0:F4}", b);
        }
    }
}
