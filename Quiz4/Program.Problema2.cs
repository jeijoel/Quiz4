using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    public partial class Program
    {
        public static void DeterminarAnagrama(string string1, string string2)
        {
            // Dividir el string en un array de characteres
            char[] Array1 = string1.ToCharArray();
            char[] Array2 = string2.ToCharArray();

            // Contador para los arrays
            int[] Counter1 = new int[256];
            int[] Counter2 = new int[256];

            // Verificar si la longituid de las palabras es la misma
            if (Array1.Length != Array2.Length)
            {
                Console.WriteLine("Los strings no son de la misma longitud");
                return;
            }
            // Counter para la frecuencia de cada caracter
            for (int i = 0; i < string1.Length; i++)
            {
                Counter1[string1[i]]++;
                Counter2[string2[i]]++;
            }
            // Comparar cada counter
            for (int i = 0; i < 256; i++)
            {
                if (Counter1[i] != Counter2[i])
                {
                    Console.WriteLine("Los strings no son anagramas");
                    return;
                }
            }
            Console.WriteLine("Los strings son anagramas");
        }
    }
}
