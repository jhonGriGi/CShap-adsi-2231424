using System;
using System.Collections.Generic;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
          // Definicion
          List<string> listaColores = new List<string>();

          // Agregar elementos a la lista
          listaColores.Add("Amarillo");
          listaColores.Add("Rojo");
          listaColores.Add("verde");
          listaColores.Add("Blanco");
          
          Console.WriteLine("La lista tiene "+listaColores.Count+" elementos");

          // Acceso a los elementos de la lista
          Console.WriteLine("Elemento posicion 0: "+listaColores[0]);
          listaColores[0] = "Azul";
          Console.WriteLine("Elemento posicion 1: "+listaColores[1]);

          Console.WriteLine("*****************************");
          for(int i=0; i<listaColores.Count; i++){
            Console.WriteLine("Elemento "+i+": "+listaColores[i]);
          }
          Console.WriteLine("*****************************");

          listaColores.Sort();
          foreach(string color in listaColores){
            Console.WriteLine("El elemento es: "+color);
          }
          Console.WriteLine("*****************************");

          List<string> listaFrutas = new List<string>();
          Console.WriteLine("Digite la cantidad de frutas");
          _ = int.TryParse(Console.ReadLine(), out int cantidadFrutas);

          // Solicitar los n datos para ingresar a la lista
          for(int i=0; i<cantidadFrutas; i++){
            Console.WriteLine("Ingrese una fruta");
            listaFrutas.Add(Console.ReadLine());
          }

          // Visualizacion elementos lista
          foreach(string item in listaFrutas){
            Console.WriteLine("La fruta es: "+item);
          }

          // Lista numerica
          List<double> listaNotas = new List<double>();

          Console.WriteLine("Ingrese la cantidad de notas");
          _ = int.TryParse(Console.ReadLine(), out int cantNotas);

          for(int i=0; i<cantNotas; i++){
            Console.WriteLine("Inserte la nota");
            _ = double.TryParse(Console.ReadLine(), out double nota);
            listaNotas.Add(nota);
          }
          
          double suma = 0, prom;
          // Visualizacion lista Notas
          Console.WriteLine("*************************");
          foreach(double item in listaNotas){
            suma = item;
          }

          prom = suma / cantNotas;
          Console.WriteLine("El promedio es: "+prom);
        }
    }
}
