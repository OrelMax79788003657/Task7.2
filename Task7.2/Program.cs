using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону куба:");
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;
            GetParam(a, out S, out V);
            Console.WriteLine(" Площадь куба = {0}. Объем куба = {1}", S, V);
            Console.ReadKey();
        }
        static void GetParam(int a, out double S, out double V)
        {
            S = a * a;
            V = S * a;
        }
    }
}
