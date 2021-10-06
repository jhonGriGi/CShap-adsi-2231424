/* 
*********************************************************
Este archivo solo es para simular el main 
y no meter todo el codigo en el archivo principal
*********************************************************

*/

using System;
using System.Collections.Generic;

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
            Senamon[] equipo = new Senamon[5];

            Entrenador entrenador;

            ControlBattle controlBattle = new ControlBattle();
            
            do
            {
                Console.WriteLine("Ingrese la cantidad de entrenadores");
                _ = int.TryParse(Console.ReadLine(), out entrenadores);
            } while (entrenadores <= 0);
            
            // Asignacion de informacion de los entrenadores
            for (int i = 0; i < entrenadores; i++)
            {
                 entrenador = new Entrenador();

                Console.WriteLine("Ingrese el nombre del entrenador");
                name = Console.ReadLine();

                Console.WriteLine("Ingrese el email del entrenador");
                email = Console.ReadLine();
                
                Console.WriteLine("Ingrese la fecha de nacimiento");
                _ = DateTime.TryParse(Console.ReadLine(), out nacimiento);
                
                entrenador.Name = name;
                entrenador.Email = email;
                entrenador.Birthday = nacimiento;
                entrenador.Experience = experience;
                entrenador.WonBattles = 0;

                vectEntrenador = new Entrenador[entrenadores];
                vectEntrenador[i] = entrenador;
                
                controlBattle.SetListEntrenadores(entrenador);
                
                 // Se muestran los Senamones disponibles
                AsignamentSenamon asignacion = new AsignamentSenamon();

                asignacion.asignamentSenamon();

                asignacion.ShowAsignamentSenamon();

                // Se ingresa los numeros de los senamones seleccionados
                for (int j = 0; j < 5; j++)
                {
                    do
                    {
                        Console.Write($"Ingresa el numero del senamon {j + 1} para tu equipo: ");
                        _ = int.TryParse(Console.ReadLine(), out opcion);
                        Console.WriteLine("---------------------------------------");
                        
                        if (opcion > asignacion.GetListSenamon().Count)
                            Console.WriteLine("Error, opcion fuera de rango");
                            
                    } while (opcion <= 0 || opcion > asignacion.GetListSenamon().Count);

                    entrenador.vectSenamon[j] = asignacion.GetListSenamon()[opcion];

                }

                // se muestran los Senamones en el equipo 

                controlBattle.BattleTeam(Seleccion[0], Seleccion[1],Seleccion[2],Seleccion[3],Seleccion[4]);

                for (int k = 0, length = controlBattle.GetListEntrenadores().Count; k < length; k++)
                {
                    for (int j = 0, length2 = controlBattle.GetBattleTeam().Count; j < length2; j++)
                    {
                        Console.WriteLine(controlBattle.GetBattleTeam()[j].Name);
                        Console.WriteLine("------------------------------------");
                    }
                }
            }

           
        }
    }
}