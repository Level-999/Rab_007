using System;

namespace Rab_007_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше
            // (создать метод для вычисления  площади  треугольника по длинам его сторон).
            // Для решения задачи можно использовать формулу Герона S=V p*(p-x)*(p-y)*(p-z)
            // где x, y, z – стороны треугольника, p – полупериметр.

            Console.WriteLine("Введите размеры сторон первого треугольника");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());

            double P1, S1;

            GeomParam1(a1, b1, c1, out P1, out S1);
            Console.WriteLine("Периметр первого прямоугольника");
            Console.WriteLine("{0:f3}", P1);
            Console.WriteLine("Площадь первого прямоугольника");
            Console.WriteLine("{0:f3}", S1);

            Console.WriteLine();
            Console.WriteLine("Введите размеры сторон второго треугольника");

            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());

            double P2, S2;

            GeomParam2(a2, b2, c2, out P2, out S2);
            Console.WriteLine("Периметр второго прямоугольника");
            Console.WriteLine("{0:f3}", P2);
            Console.WriteLine("Площадь второго прямоугольника");
            Console.WriteLine("{0:f3}", S2);


            Console.WriteLine();

            if (S1 > S2)
                
            {
                Console.WriteLine("Площадь первого треугольника больше.\nПлощадь первого треугольника равна {0:f3}", S1);
            }

            else            

            {
                if (S1 < S2)
                Console.WriteLine("Площадь второго треугольника больше.\nПлощадь второго треугольника равна {0:f3}", S2);

                else

                Console.WriteLine("Площади треугольников равны");
            }
            
            //Console.WriteLine("Площадь треугольника больше");


        }
        static void GeomParam1(int a1, int b1, int c1, out double P1, out double S1)
        {
            P1 = (a1 + b1 + c1) / 2;
            S1 = Math.Sqrt(P1 * (P1 - a1) * (P1 - b1) * (P1 - c1));
        }

        static void GeomParam2(int a2, int b2, int c2, out double P2, out double S2)
        {
            P2 = (a2 + b2 + c2) / 2;
            S2 = Math.Sqrt(P2 * (P2 - a2) * (P2 - b2) * (P2 - c2));

        }

        
    }

}
