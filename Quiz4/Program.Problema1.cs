using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    public partial class Program
    {
        private int[] unirIntervalosTraslapados(int[] arreglo1, int[] arreglo2)
        {
            int[] resultado;
            if (arreglo1[1] >= arreglo2[0])
            {
                resultado = new int[] { arreglo1[0], arreglo2[1] };
            }
            else if (arreglo2[1] >= arreglo1[0])
            {
                resultado = new int[] { arreglo2[0], arreglo1[1] };
            }
            else
            {
                resultado = new int[] { };
            }
            return resultado;
        }

        private void ordenamientoPorSeleccion(int[][] arreglo)
        {
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arreglo.Length - 2; j++)
                {
                    if (arreglo[j][0] < arreglo[minIndex][0])
                    {
                        minIndex = j;
                    }
                    else if (arreglo[j][0] == arreglo[minIndex][0] && arreglo[j][1] < arreglo[minIndex][1]) 
                    {
                        minIndex = j;
                    }
                }
                int[] temporal = arreglo[minIndex];
                arreglo[minIndex] = arreglo[i];
                arreglo[i] = temporal;
            }
        }

        public int[][] UnirIntervalosTraslapados(int[][] arregloDeArreglos)
        {
            int[][] resultado = new int[][] { };
            ordenamientoPorSeleccion(arregloDeArreglos);
            return unirIntervalosTraslapadosRecursivo(arregloDeArreglos, new int[] { }, resultado, 0, 0);
        }

        private int[][] unirIntervalosTraslapadosRecursivo(int[][] arregloDeArreglos, int[] arreglo, int[][] resultado, int tamano, int i)
        {
            int j = i + 1;
            if (i == arregloDeArreglos.Length - 1)
            {
                return resultado;
            }
            else
            {
                if (arreglo.Length == 0 && i != 0)
                {
                    tamano += 2;
                    int[][] nuevoResultado = new int[tamano][];
                    int indice = 0;
                    while (indice < resultado.Length)
                    {
                        nuevoResultado[indice] = resultado[indice];
                        indice++;
                    }
                    nuevoResultado[indice++] = arregloDeArreglos[i - 1];
                    nuevoResultado[indice] = arregloDeArreglos[j - 1];
                    arreglo = unirIntervalosTraslapados(arregloDeArreglos[i], arregloDeArreglos[j]);
                    return unirIntervalosTraslapadosRecursivo(arregloDeArreglos, arreglo, nuevoResultado, tamano, i + 1);
                }
                else
                {
                    tamano += 1;
                    int[][] nuevoResultado = new int[tamano][];
                    int indice = 0;
                    while (indice < resultado.Length)
                    {
                        nuevoResultado[indice] = resultado[indice];
                        indice++;
                    }
                    nuevoResultado[indice] = arreglo;
                    arreglo = unirIntervalosTraslapados(arregloDeArreglos[i], arregloDeArreglos[j]);
                    return unirIntervalosTraslapadosRecursivo(arregloDeArreglos, arreglo, nuevoResultado, tamano, i + 1);
                }
            }
        }
    }
}
