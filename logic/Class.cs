using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calizwiwi.logic
{
    internal class Class
    {
        //-----------------------------------------------------------------------------------BURBUJA
        public void Practica1()
        {
            int n;
            Console.WriteLine("Que tan grande master");
            n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("escribeme el numero we", (i+1));
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int vec;
                    if (num[i] > num[j])
                    {
                        vec = num[i];
                        num[i] = num[j];
                        num[j] = vec;
                    }
                }
            }
            Console.WriteLine("Estos son: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadKey();
        }
        ///-----------------------------------------------------------------------------------SELECCION ALV
        public void Practica2()
        {
            int[] lista = new int[5];
            for(int i= 0; i < lista.Length; i++)
            {
                Console.WriteLine("Escribir el numero");
                lista[i] = Convert.ToInt32(Console.ReadLine());
            }
            int menor = 0;
            int pos = 0;
            int temp = 0;
            for(int i=0;i<lista.Length-1; i++)
            {
                menor = lista[i];
                pos= i;
                for(int j=i+1; j<lista.Length; j++)
                {
                    if (lista[j] < menor)
                    {
                        menor = lista[j];
                        pos = j;
                    }
                    
                }
                if (pos != i)
                {
                    temp = lista[i];
                    lista[i] = lista[pos];
                    lista[pos] = temp;
                }
            }
            Console.WriteLine("La lista ordenada es: ");
            for(int i= 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine("Aqui ordenada descendente: ");
            for(int i= lista.Length-1; i >= 0;i--)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();
        }
    }
}
