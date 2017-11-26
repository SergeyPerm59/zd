using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd
{
    class Program
    {
        static void Main(string[] args)
        {
            int chet = 0;
            int[] mass = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //for (int i = 0; i < mass.Length; i++)
            //{
            //    Console.WriteLine(mass[i] + " " + i);
            //}
            //Console.WriteLine("\nКоличество четных элементов массива: " + chet);

            //for (int i = 1; i < mass.Length; i+=2)
            //{
            //Console.Write(mass[i] + " ");
            //    chet += 1;
            //}
            //Console.WriteLine("\nКоличество четных элементов массива: " + chet);

            //int sred = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    sred += mass[i];
            //}

            //Console.WriteLine("\nСреднее арифметическое элементов массива: " + sred / mass.Length);

            int max = int.MinValue;
            int min = int.MaxValue;
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (min > mass[i]) min = mass[i];
            //    if (max < mass[i]) max = mass[i];
            //}
            //Console.WriteLine("\nmin = " + min + "   max = " +max);

            int minIndex = 0, maxIndex=0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (max < mass[i])
                {
                    max = mass[i];
                    maxIndex = i;
                }
                if (min < mass[i])
                {
                    min = mass[i];
                    minIndex = i;
                }

            }

            Console.WriteLine("\nНомер максимального (минимального) элемента массива: " +  minIndex + "   " + maxIndex);
            Console.ReadLine();

        }
    }
}
