using System;

namespace Rab_007_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.

            Console.WriteLine("Введите размер ребра куба");
           
            int a = Convert.ToInt32(Console.ReadLine());
          

            double v, s;

            GeomParam(a, out v, out s);
            Console.WriteLine("Объём куба");
            Console.WriteLine("{0:f3}", v);
            Console.WriteLine("Площадь поверхности куба");
            Console.WriteLine("{0:f3}", s);

        }

        static void GeomParam(int a, out double v, out double s)
        {
            v = a*a*a;
            s = 6*(a*a);
        }
    }

}
