using System;

namespace ejercicio1
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Calcular el promedio de 50 valores almacenados en un vector. Determinar además cuantos son
         mayores que el promedio, imprimir el promedio, el número de datos mayores que el promedio y una
         lista de valores mayores que el promedio.*/

      double[] arrayPromedio = new double[50];
      double sumaTotal = 0;

      for(int i = 0; i < arrayPromedio.Length; i++){
        Console.WriteLine("Ingrese el valor de " + (i+1));
        _ = double.TryParse(Console.ReadLine(), out arrayPromedio[i]);
      }

      for(int i = 0; i < arrayPromedio.Length; i++){
        sumaTotal += arrayPromedio[i];
      }

      double promedio = sumaTotal / arrayPromedio.Length;

      int cantMayoresProm = 0;

      for(int j = 0; j < arrayPromedio.Length; j++){
        if(arrayPromedio[j] > promedio){
          cantMayoresProm++;
        }
      }

      double[] mayoresPromedio = new double[cantMayoresProm];

      int k = 0;
      for(int m = 0; m < arrayPromedio.Length; m++){
        if(arrayPromedio[m] > promedio){
          mayoresPromedio[k] = arrayPromedio[m];
          k++;
        }
      }

      Console.WriteLine("El promedio es: " + promedio);
      Console.WriteLine("La cantidad de datos mayores al promedio es: " + cantMayoresProm);
      Console.WriteLine("La lista de valores mayores al promedio es: ");
      for(int g = 0; g < mayoresPromedio.Length; g++){
        Console.WriteLine((g+1) + " = " + mayoresPromedio[g]);
      }
    }
  }
}
