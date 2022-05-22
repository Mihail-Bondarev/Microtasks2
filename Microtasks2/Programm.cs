using System;

namespace Microtasks2
{
    class Programm
    {
        private static void Main(string[] args)
        {
            double t = 12;
            double T = 0.04;
            Console.WriteLine("Время колебания = " + t + ", период колебания = " + T);
            double n = t / T;
            Console.WriteLine("Количество колебаний = " + n);
            double t1 = 7;
            double T1 = 0.029;
            Console.WriteLine("Время колебания = " + t1 + ", период колебания = " + T1);
            double n1 = t1 / T1;
            Console.WriteLine("Количество колебаний = " + n1);
            double t2 = Convert.ToDouble(Console.ReadLine());
            double T2 = 0.083;
            Console.WriteLine("Время колебания = " + t2 + ", период колебания = " + T2);
            double n2 = t2 / T2;
            Console.WriteLine("Количество колебаний = " + n2);

            int temp;
            int[] mass = { 7, 5, 2, 3, 9, 6 };
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = i + 1; j < mass.Length; j++) 
                {
                    if (mass[i]> mass[j]) 
                    {
                        temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                    }
                }
                Console.WriteLine(mass[i]);
            }
        }
    }
}
