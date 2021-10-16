using System;
using System.Collections.Generic;

namespace Senamon
{
    public class AsignamentSenamon
    {
        // Atributos
        public List<Senamon> listSenamon = new List<Senamon>();

        // Constructor
        public AsignamentSenamon()
        {
            Senamon senamon = new Senamon("Bulbasaur", 1, "Planta", 6.9f, 45, 49, 1, "Senamon tipo Planta en la primera evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Ivysaur", 1, "Planta", 13.0f, 60, 62, 2, "Senamon tipo Planta en la Segunda evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Venusaur", 1, "Planta", 100.0f, 80, 82, 3, "Senamon tipo planta en la tercera evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Charmander", 1, "Fuego", 8.5f, 39, 52, 1, "Senamon tipo Fuego en la primera evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Charmeleon", 1, "Fuego", 19.0f, 58, 64, 2, "Senamon tipo Fuego en la Segunda evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Charizard", 1, "Fuego", 90.5f, 78, 84, 3, "Senamon tipo Fuego en la Tercera evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Squirtle", 1, "Agua", 9.0f, 44, 48, 1, "Senamon tipo Agua en la primera evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Wartortle", 1, "Agua", 22.5f, 59, 63, 2, "Senamon tipo Agua en la segunda evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Blastoise", 1, "Agua", 85.5f, 79, 83, 3, "Senamon tipo Agua en la tercera evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Caterpie", 1, "Bicho", 2.9f, 45, 30, 1, "Senamon tipo Bicho en la primera evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Metapod", 1, "Bicho", 9.9f, 50, 20, 2, "Senamon tipo Bicho en la segunda evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Butterfree", 1, "Bicho", 32.0f, 60, 45, 3, "Senamon tipo Bicho en la tercera evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Weedle", 1, "Bicho", 3.2f, 40, 35, 1, "Senamon tipo Bicho en la primera evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Kakuna", 1, "Bicho", 10.0f, 45, 25, 2, "Senamon tipo Bicho en la segunda evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Beedrill", 1, "Bicho", 29.5f, 65, 90, 3, "Senamon tipo Bicho en la tercera evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Pidgey", 1, "Volador", 1.8f, 40, 45, 1, "Senamon tipo Volador en la primera evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Pidgeotto", 1, "Volador", 30.0f, 63, 60, 2, "Senamon tipo Volador en la segunda evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Pidgeot", 1, "Volador", 39.5f, 83, 80, 3, "Senamon tipo Volador en la tercera evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Rattata", 1, "Normal", 3.5f, 30, 56, 1, "Senamon tipo Normal en la primera evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Raticate", 1, "Normal", 18.5f, 55, 81, 3, "Senamon tipo Normal en la Segunda evolucion");
            listSenamon.Add(senamon);
            senamon = new Senamon("Pikachu", 1, "Electrico", 6.0f, 35, 55, 1, "Senamon tipo Electrico en la primera evolucion");
            listSenamon.Add(senamon);
        }

        // Metodos
        public List<Senamon> GetListSenamon()
        {
            return this.listSenamon;
        }

        public void ShowAsignamentSenamon()
        {
            Console.WriteLine($"Ingresa el numero del senamon para tu equipo");

            for (int i = 0, length = this.listSenamon.Count; i < length; i++)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($" Senamon: #{i}");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"   >>>Nombre: {this.listSenamon[i].Name}");
                Console.WriteLine($"   >>>Nivel: {this.listSenamon[i].Level}");
                Console.WriteLine($"   >>>Salud: {this.listSenamon[i].Health}");
                Console.WriteLine($"   >>>Ataque: {this.listSenamon[i].Attack}");
                Console.WriteLine($"   >>>Descripcion: {this.listSenamon[i].Description}");
                Console.WriteLine("---------------------------------------");

            }
        }
    }
}