using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    public partial class Program
    {
        public string DeterminarAnagrama(string string1, string, string2)
        {
            // Dividir el string en un array de characteres
            char[] Array1 = string1.ToCharArray();
            char[] Array2 = string2.ToCharArray();
            // Verificar si la longituid de las palabras es la misma
            if (Array1.length == Array2.length)
            {
                for (i = 0; i < Array1.length; i++) ;
                {
                    // 2do for loop
                    for (j = 0; j < Array2.length; j++) ;
                    if (Array1[i] != Array2[j])
                    {
                        Console.WriteLine("Los strings no son anagramas.");
                    }
                    else
                    {
                        Console.WriteLine("Los strings son anagramas.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Las strings pasados no son anagramas porque no tienen la misma cantidad de caracteres.");
                return -1;
            }

        }
    }
}
