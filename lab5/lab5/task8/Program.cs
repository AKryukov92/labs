﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            String t = Console.ReadLine();
            a = double.Parse(t);
            t = Console.ReadLine();
            b = double.Parse(t);
            t = Console.ReadLine();
            c = double.Parse(t);
            if (b * b - 4 * a * c < 0 )
            {
                Console.WriteLine("Вещественных корней уравнения {0}x^2 + {1}x + {2} = 0 нет", a, b, c);
                
            }
            if (b * b - 4 * a * c > 0 )
            {
                Console.WriteLine("У уравнения {0}x^2 + {1}x + {2} = 0 два вещественных корня", a, b, c);
            }
            if (b * b - 4 * a * c == 0)
            {
                Console.WriteLine("Уравнение {0}x^2 + {1}x + {2} = 0 имеет один корень", a, b, c);
            }
            if (a == 0)
            {
                Console.WriteLine("Данное уравнение не является квадратным");
            }
        }
    }
}
