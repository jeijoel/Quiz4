using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace Quiz4
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            string miString = "";
            Console.WriteLine("Hello, World!");
            int[] arreglo;
            arreglo = [];
            Console.WriteLine(arreglo.Length);
            Console.WriteLine(arreglo);
            int[][] miArreglo = new int[4][];
            miArreglo[0] = new int[] { 1, 3 };
            miArreglo[1] = new int[] { 6, 8 };
            miArreglo[2] = new int[] { 9, 10 };
            miArreglo[3] = new int[] { 2, 4 };

            // Create an instance of Program to call the non-static method
            Program programInstance = new Program();
            for (int i = 0; i < miArreglo.Length; i++)
            {
                miString += "{" + $"{miArreglo[i][0]}, {miArreglo[i][1]}" + "}";
                if (i != miArreglo.Length - 1) miString += ", ";
            }
            Console.WriteLine("{" + miString + "}");
            DeterminarAnagrama("abc", "defa");
        }
        
    }
}
