using System;
using System.Collections.Specialized;

namespace recuperacion
{
    class Entrenador
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public int Experience { get; set; }
        public int WonBattles { get; set; }

        public Senamon[] vectSenamon = new Senamon[5];

        private AsignamentSenamon _asignamentSenamon = new AsignamentSenamon();

        public Entrenador() { }

        public Senamon[] GetVectSenamon()
        {
            return this.vectSenamon;
        }

        public void SetVectSenamon()
        {
            int opcion;

            for(int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese la opcion del Senamon {i}: ");
                _ = int.TryParse(Console.ReadLine(), out opcion);

                this.vectSenamon[i] = _asignamentSenamon.listSenamon[opcion];
            }
        }

        public void ReplaceSenamon()
        {
            int cambio, newSenamon; 
            
            Console.WriteLine("Estos son los nuevos Senamones:");

            _asignamentSenamon.GetListSenamon();

            do
            {
                Console.WriteLine("Ingresa el nuevo senamon");
                _ = int.TryParse(Console.ReadLine(), out newSenamon);

                if (newSenamon < 0 || newSenamon > _asignamentSenamon.GetListSenamon().Count)
                    Console.WriteLine("Error, vuelva a digitar la opcion");
            } while (newSenamon < 0 || newSenamon > _asignamentSenamon.GetListSenamon().Count);

            Console.WriteLine("Estos son tus Senamones:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($" Senamon: #{i + 1}");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"   >>>Nombre: {this.vectSenamon[i].Name}");
                Console.WriteLine($"   >>>Nivel: {this.vectSenamon[i].Level}");
                Console.WriteLine($"   >>>Salud: {this.vectSenamon[i].Health}");
                Console.WriteLine($"   >>>Ataque: {this.vectSenamon[i].Attack}");
                Console.WriteLine("---------------------------------------");
            }

            do
            {
                Console.Write("Ingrese el senamon a cambiar: ");
                _ = int.TryParse(Console.ReadLine(), out cambio);

                if (cambio < 0 || cambio > this.vectSenamon.Length)
                    Console.WriteLine("Error, vuelve a digitar la opcion");
                
            } while (cambio < 0 || cambio > this.vectSenamon.Length);

            this.vectSenamon[cambio] = _asignamentSenamon.GetListSenamon()[newSenamon];
        }

    }
}