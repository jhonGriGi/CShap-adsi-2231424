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
            Senamon senamon = new Senamon("Bulbasaur", 1, "Planta", 6.9f, 45, 49, 1);
            listSenamon.Add(senamon);
            senamon = new Senamon("Venusaur", 1, "Planta", 100.0f, 80, 82, 3);
            listSenamon.Add(senamon);
            senamon = new Senamon("Charmander", 1, "Fuego", 8.5f, 39, 52, 1);
            listSenamon.Add(senamon);
            senamon = new Senamon("Charizard", 1, "Fuego", 90.5f, 78, 84, 3);
            listSenamon.Add(senamon);
            senamon = new Senamon("Squirtle", 1, "Agua", 9.0f, 44, 48, 1);
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
                Console.WriteLine("---------------------------------------");

            }
        }
    }
}