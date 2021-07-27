using System;
using System.Collections;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando los metodos de listas con arraylist 
            ArrayList personajesLol = new ArrayList();

            // Agregar elementos
            personajesLol.Add("Garen");
            personajesLol.Add("Jhin");
            personajesLol.Add("Katarina");
            personajesLol.Add("Nidalee");
            personajesLol.Add("Sett");
            personajesLol.Add("Garen");

            foreach(String personaje in personajesLol){
                Console.WriteLine($"Los personajes son: {personaje}");
            }
            Console.WriteLine("*******************************\n");

            // Agregar un elemento en una posicion especifica
            personajesLol.Insert(1, "Pyke");

            foreach(String personaje in personajesLol){
                Console.WriteLine($"La lista con el nuevo personaje es: {personaje}");
            }
            Console.WriteLine("*******************************\n");

            // Ordenar la lista de forma alfabetica
            personajesLol.Sort();

            foreach(String personaje in personajesLol){
                Console.WriteLine($"La lista ordenada es: {personaje}");
            }
            Console.WriteLine("*******************************\n");

            // Encontrar un elemento en la lista
            Console.WriteLine("Ingrese un nombre de personaje");
            string busquedaPersonaje = Console.ReadLine();

            if(personajesLol.Contains(busquedaPersonaje)) {
                Console.WriteLine("El personaje se encuentra en la lista");
            }
            else {
                Console.WriteLine("El personaje no se encuentra en la lista");
            }
            Console.WriteLine("*******************************\n");

            Console.WriteLine($"El personaje se encuentra en el indice {personajesLol.IndexOf(busquedaPersonaje)}");
            Console.WriteLine("*******************************\n");

            // funcion count 
            Console.WriteLine($"La lista tiene {personajesLol.Count} en total");
            Console.WriteLine("*******************************\n");

            // Borrar la lista
            personajesLol.Clear();
            Console.WriteLine("La lista ha sido borrada");
        }
    }
}
