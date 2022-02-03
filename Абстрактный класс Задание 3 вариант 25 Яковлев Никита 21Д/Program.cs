//Задание 3
//Окружность, геометрическая фигура, линия, заливка (Абстрактный класс)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Яковлев_Н_21Д_Задание_2__номер_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fill fill = new fill();
            line line = new line();
            Circle circle = new Circle();

            geo_figure[] geo_figure = new geo_figure[10];

            geo_figure[0] = fill;
            geo_figure[1] = line;
            geo_figure[2] = circle;

            line.degree = 43;

            Console.WriteLine((geo_figure[1] as line).degree);

            if (geo_figure[0] is fill)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadKey();
        }
    }
}