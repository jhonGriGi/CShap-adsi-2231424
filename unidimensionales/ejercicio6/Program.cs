using System;

namespace ejercicio6
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Diseñe un algoritmo que lea dos vectores A y B de 7 elementos cada uno y multiplique el primer
         elemento de A con el último elemento de B y luego el segundo elemento de A por el sexto elemento
         de B y así sucesivamente hasta llegar al séptimo elemento de A por el primer elemento de B. El
         resultado de la multiplicación almacenarlo en un vector C. Mostrar el resultado.*/
      int[] vectorA = new int[7] {2,4,6,8,10,12,14};
      int[] vectorB = new int[7] {1,3,5,7,9,11,13};
      int[] vectorResultado = new int[7];

      Array.Reverse(vectorB);

      for(int i = 0; i < vectorA.Length; i++){
        vectorResultado[i] = vectorA[i] * vectorB[i];
      }
      Console.WriteLine("Lista resultante: ");
      for(int i = 0; i < vectorResultado.Length; i++){
        Console.WriteLine((i+1) + ": " + vectorResultado[i]);
      }
    }
  }
}
