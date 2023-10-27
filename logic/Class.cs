using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calizwiwi.logic
{
    internal class Class
    {
        internal class Class
    {
        static void Main(string[] args)
        {
            int[,] t = new int[4, 3];
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for(int x=0; x<t.GetLength(1); x++)
                {
                    Console.Write($"Ingrese el valor para t[{i},{x}]:");
                    t[i,x] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int m= t[0,0];
            for(int i = 0; i<t.GetLength(0); i++)
            {
                for(int x = 0; x<t.GetLength(1); x++)
                {
                    if (t[i,x] < m)
                    {
                        m = t[i,x];
                    }
                }
            }
            Console.WriteLine("El de menor valor en t es: " + m);
            Console.WriteLine($"{t[0, 0]}\t{t[0, 1]}\t{t[0, 2]}");

            int total = t[0, 2] + t[1, 2] + t[2, 2] + t[3, 2];
            Console.WriteLine("Total de la tercera columna: " + total);

            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int x = 0; x < t.GetLength(1); x++)
                {
                    Console.Write($"t[{i},{x}]\t");
                }
                Console.WriteLine();
            }
    }
}
