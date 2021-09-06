using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, nivel, tipoDeJuego;
            int edad, horasDeJuego, victorias, derrotas;

            Jugador jugador = new Jugador();

            Console.WriteLine("Cual es tu nombre?");
            nombre = Console.ReadLine();

            jugador.setNombre(nombre);

            Console.WriteLine("Cual es tu nivel? (casual, regular, profesional).");
            nivel = Console.ReadLine();

            jugador.setNivel(nivel);

            Console.WriteLine("Cual es tu tipo de juego? (fisico, electronico). ");
            tipoDeJuego = Console.ReadLine();

            jugador.setTipoDeJuego(tipoDeJuego);

            Console.WriteLine("Cual es tu edad?");
            _ = int.TryParse(Console.ReadLine(), out edad);

            jugador.setEdad(edad);

            Console.WriteLine("Cuantas horas juegas?");
            _ = int.TryParse(Console.ReadLine(), out horasDeJuego);

            jugador.setHorasDeJuego(horasDeJuego);

            Console.WriteLine("Cuantas victorias tienes?");
            _ = int.TryParse(Console.ReadLine(), out victorias);

            Console.WriteLine("Cuantas derrotas tienes?");
            _ = int.TryParse(Console.ReadLine(), out derrotas);

            Console.WriteLine("Esta es tu informacion!!!");
            Console.WriteLine($"    >>>>Nombre: {jugador.getNombre()}");
            Console.WriteLine($"    >>>>Edad: {jugador.getEdad()}");
            Console.WriteLine($"    >>>>Tipo de Juego: {jugador.getTipoDeJuego()}");
            Console.WriteLine("********************************");
            Console.WriteLine("Tu promedio es: ");
            Console.WriteLine($"    >>>>Promedio: {jugador.promedio(victorias, derrotas)}");            
        }
    }
}
