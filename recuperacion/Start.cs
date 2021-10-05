/* 
*********************************************************
Este archivo solo es para simular el main 
y no meter todo el codigo en el archivo principal
*********************************************************

*/

using System;
using System.Runtime.Serialization;

namespace recuperacion
{
    class Start 
    {
        public Start()
        {
            start();
        }

        public void start()
        {
            int entrenadores;
            string name, email;
            int experience = 0, opcion;
            Entrenador[] vectEntrenador;
            int[] Seleccion = new int[5];
            DateTime nacimiento;

            do
            {
                Console.WriteLine("Ingrese la cantidad de entrenadores");
                _ = int.TryParse(Console.ReadLine(), out entrenadores);
            } while (entrenadores <= 0);

            for (int i = 0; i < entrenadores; i++)
            {
                Entrenador entrenador = new Entrenador();

                Console.WriteLine("Ingrese el nombre del entrenador");
                name = Console.ReadLine();

                Console.WriteLine("Ingrese el email del entrenador");
                email = Console.ReadLine();
                
                Console.WriteLine("Ingrese la fecha de nacimiento");
                _ = DateTime.TryParse(Console.ReadLine(), out nacimiento);
                
                entrenador.Name = name;
                entrenador.Email = email;
                entrenador.Birthday = nacimiento;

                vectEntrenador = new Entrenador[entrenadores];
                vectEntrenador[i] = entrenador;
            }

            AsignamentSenamon asignacion = new AsignamentSenamon();

            asignacion.asignamentSenamon();
            
            Console.WriteLine($"Ingresa el numero del senamon para tu equipo");

            for (int i = 0, length = asignacion.GetListSenamon().Count; i < length; i++)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($" Senamon: #{i + 1}");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"   >>>Nombre: {asignacion.GetListSenamon()[i].Name}");
                Console.WriteLine($"   >>>Nivel: {asignacion.GetListSenamon()[i].Level}");
                Console.WriteLine($"   >>>Salud: {asignacion.GetListSenamon()[i].Health}");
                Console.WriteLine($"   >>>Ataque: {asignacion.GetListSenamon()[i].Attack}");
                Console.WriteLine("---------------------------------------");

            }

            for (int i = 0, length = asignacion.GetListSenamon().Count; i < length; i++)
            {
                do
                {
                    Console.Write($"Ingresa el numero del senamon {i}: ");
                    _ = int.TryParse(Console.ReadLine(), out opcion);
                    Console.WriteLine("---------------------------------------");
                } while (opcion <= 0 && opcion > asignacion.GetListSenamon().Count);
                
                Seleccion[i] = opcion;
            }

            ControlBattle controlBattle = new ControlBattle();

            controlBattle.battleTeam(Seleccion[0], Seleccion[1],Seleccion[2],Seleccion[3],Seleccion[4]);

            for (int i = 0, length = controlBattle.GetBattleTeam().Count; i < length; i++)
            {
                Console.WriteLine(controlBattle.GetBattleTeam()[i]);
            }
        }
    }
}