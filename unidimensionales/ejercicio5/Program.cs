using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Diseñe un algoritmo que lea un número cualquiera y lo busque en el vector X, el cual tiene
               almacenados 12 elementos. Escribir la posición donde se encuentra almacenado el número en el
               vector o el mensaje “NO” si no lo encuentra.*/
          int[] vectorX = new int[12] {2,4,5,6,7,8,9,23,45,36,22,25};

          Console.WriteLine("Ingrese un valor entero: ");
          _ = int.TryParse(Console.ReadLine(), out int elemento);

          string respuesta = "", element = "si";
          int posicion = 0;
          for(int i = 0; i < vectorX.Length; i++){
            if(elemento == vectorX[i]){
              respuesta = "si";
              posicion = i;
            }
            else {
              respuesta = "No";
            }
          }
          bool resultado = element.Equals(respuesta);
          if(resultado){
            Console.WriteLine("El elemento se encuentra en la posicion: " + posicion + " del elemento");
          }
          else{
            Console.WriteLine("NO");
          }
        }
    }
}
