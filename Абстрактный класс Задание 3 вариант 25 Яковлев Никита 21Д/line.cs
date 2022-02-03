//Задание 3
//Окружность, геометрическая фигура, линия, заливка (Абстрактный класс)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Яковлев_Н_21Д_Задание_3__номер_25
{
    internal class line : geo_figure
    {
        private int _degree;

        public override void length()
        {
            Console.WriteLine("length");
        }

        public override void width()
        {
            Console.WriteLine("Width");
        }

        public int degree { get => _degree; set => _degree = value; }

        public override void Print()
        {
            Console.WriteLine("This is line");
        }
    }
}
