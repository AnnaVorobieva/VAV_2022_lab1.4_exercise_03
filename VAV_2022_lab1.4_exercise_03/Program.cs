using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAV_2022_lab1._4_exercise_03
{
    internal class Program
    {
        // задача на нахождение количества квадратов в прямоугольнике//
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число C (меньше A или B):");
            int c = Convert.ToInt32(Console.ReadLine());

            int i = c;
            int Sum1 = i;
            int n1 = 0;

            while (Sum1 <= a)
            {
                Sum1 += i;
                n1++;
            }
            Console.WriteLine("Количество отрезков С в стороне А = {0}", n1);

            int n2 = 0;
            int Sum2 = i ;
            while (Sum2 <= b)
            {
                Sum2 += i;
                n2++;
            }
            Console.WriteLine("Количество отрезков С в стороне B = {0}", n2);


            int min = (n1 <= n2) ? n1 : n2;
            Console.WriteLine("Количество квадратов в прямоугольнике = {0}", min);

            Console.ReadKey();
        }








    }
}
