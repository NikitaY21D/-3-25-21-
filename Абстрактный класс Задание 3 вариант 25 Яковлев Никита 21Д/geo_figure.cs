//Задание 3
//Окружность, геометрическая фигура, линия, заливка (Абстрактный класс)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Яковлев_Н_21Д_Задание_2__номер_25
{
    internal abstract class geo_figure
    {
        abstract public void length();

        abstract public void width();

        public virtual void Print()
        {
            Console.WriteLine("This is figure");
        }

    }
}
