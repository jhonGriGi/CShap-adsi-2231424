using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
          /* Llenar dos vectores A y B de 10 elementos cada uno, sumar el elemento uno del vector A con el
             elemento uno del vector B y así sucesivamente hasta 10, almacenar el resultado en un vector C, e
             imprimir el vector resultante.*/
          double[] arrayElementosA = new double[10];
          double[] arrayElementosB = new double[10];
          double[] arrayElementosC = new double[10];

          for(int i = 0, length = arrayElementosA.Length; i < length; i++){
            Console.WriteLine("Ingrese los valores del primer conjunto de elementos " + (i+1));
            _ = double.TryParse(Console.ReadLine(), out arrayElementosA[i]);
          }

          for(int i = 0, length = arrayElementosB.Length; i < length; i++){
            Console.WriteLine("Ingrese los valores del segundo conjunto de elementos " + (i+1));
            _ = double.TryParse(Console.ReadLine(), out arrayElementosB[i]);
          }

          for(int i = 0, length = arrayElementosC.Length; i < length; i++){
            arrayElementosC[i] = arrayElementosA[i] + arrayElementosB[i];
          }

          Console.WriteLine("Lista de la suma total");
          for(int i = 0; i<arrayElementosC.Length; i++){
            Console.WriteLine((i+1) + ": " + arrayElementosC[i]);
          }
        }
    }
}
