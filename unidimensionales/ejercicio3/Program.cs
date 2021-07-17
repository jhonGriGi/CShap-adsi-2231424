using System;

namespace ejercicio3
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Almacenar 15 números en un vector, imprimir cuantos son ceros, cuántos son negativos, cuantos
        positivos. Imprimir además la suma de los negativos, la suma de los ceros y la suma de los positivos. */

      double[] valoresTotales = new double[15];

      for(int i = 0; i < valoresTotales.Length; i++){
        Console.WriteLine("Ingrese el valor de: " + (i+1));
        _ = double.TryParse(Console.ReadLine(), out valoresTotales[i]);
      }

      int contNegativo = 0, contCeros = 0, contPositivos = 0;
      double sumNegativos = 0, sumCeros = 0, sumPositivos = 0;

      for(int i = 0; i < valoresTotales.Length; i++){
        if(valoresTotales[i] < 0){
          contNegativo++;
          sumNegativos += valoresTotales[i];
        }
        else if(valoresTotales[i] == 0){
          contCeros++;
          sumCeros += valoresTotales[i];
        }
        else{
          contPositivos++;
          sumPositivos += valoresTotales[i];
        }
      }

      Console.WriteLine("El total de negativos es: " + contNegativo);
      Console.WriteLine("La suma total de negativos es: " + sumNegativos);
      Console.WriteLine("El total de ceros es: " + contCeros);
      Console.WriteLine("La suma total de ceros es: " + sumCeros);
      Console.WriteLine("El total de positivos es: " + contPositivos);
      Console.WriteLine("La suma total de positvos es: " + sumPositivos);
    }
  }
}
