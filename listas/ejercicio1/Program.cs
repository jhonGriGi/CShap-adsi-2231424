using System;
using System.Collections;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando los metodos de listas con arraylist 
            ArrayList personajes = new ArrayList();

            // Agregar elementos
            personajes.Add("Garen");
            personajes.Add("Jhin");
            personajes.Add("Katarina");
            personajes.Add("Nidalee");
            personajes.Add("Sett");
            personajes.Add("Garen");

            foreach (String personaje in personajes)
            {
                Console.WriteLine($"Los personajes son: {personaje}");
            }
            Console.WriteLine("*******************************\n");

            // Agregar un elemento en una posicion especifica
            personajes.Insert(1, "Pyke");

            foreach (String personaje in personajes)
            {
                Console.WriteLine($"La lista con el nuevo personaje es: {personaje}");
            }
            Console.WriteLine("*******************************\n");

            // Ordenar la lista de forma alfabetica
            personajes.Sort();

            foreach (String personaje in personajes)
            {
                Console.WriteLine($"La lista ordenada es: {personaje}");
            }
            Console.WriteLine("*******************************\n");

            // Encontrar un elemento en la lista
            Console.WriteLine("Ingrese un nombre de personaje");
            string busquedaPersonaje = Console.ReadLine();

            if (personajes.Contains(busquedaPersonaje))
            {
                Console.WriteLine("El personaje se encuentra en la lista");
            }
            else
            {
                Console.WriteLine("El personaje no se encuentra en la lista");
            }
            Console.WriteLine("*******************************\n");

            Console.WriteLine($"El personaje se encuentra en el indice {personajes.IndexOf(busquedaPersonaje)}");
            Console.WriteLine("*******************************\n");

            // funcion count 
            Console.WriteLine($"La lista tiene {personajes.Count} en total");
            Console.WriteLine("*******************************\n");

            // Borrar la lista
            personajes.Clear();
            Console.WriteLine("La lista ha sido borrada");
        }
    }
}
