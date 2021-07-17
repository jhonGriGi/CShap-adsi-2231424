using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Almacenar 8 números en un vector, almacenarlos en otro vector en orden inverso al vector original
               e imprimir el vector resultante.*/
          double[] miArray = new double[8] {12, 42, 39, 25, 82, 69, 29,99};
          Console.WriteLine("Array Inicial: ");
          for(int i = 0; i < miArray.Length; i++){
            Console.WriteLine((i+1) + ": " + miArray[i]);         
          }

          Array.Reverse(miArray);

          Console.WriteLine("\n");
          Console.WriteLine("***********************************");
          Console.WriteLine("\n");
          Console.WriteLine("Array Inverso:");
          for(int i = 0; i < miArray.Length; i++){
            Console.WriteLine((i+1) + ": " + miArray[i]);
          }
        }
    }
}
