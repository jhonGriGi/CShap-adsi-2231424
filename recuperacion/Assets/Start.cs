/* 
*********************************************************
Este archivo solo es para simular el main 
y no meter todo el codigo en el archivo principal
*********************************************************

*/

using System;
using System.Collections.Generic;
using System.Assets.*

namespace recuperacion
{
    class Start 
    {
        public Entrenador[] vectEntrenador;
        private AsignamentSenamon _asignamentSenamon;

        public Start()
        {
            start();
        }

        public  void start()
        {
            int entrenadores;
            
            string name, email;
            DateTime birthday;

            do
            {
                Console.Write("Ingrese la cantidad de entrenadores: ");
                _ = int.TryParse(Console.ReadLine(), out entrenadores);
                
                if (entrenadores <= 0)
                    Console.WriteLine("Error, vuelva a digitar el valor");
                
            } while (entrenadores <= 0);

            for (int i = 0; i < entrenadores; i++)
            {
                Entrenador entrenador = new Entrenador();
                
                Console.Write("Ingrese el nombre del entrenador: ");
                name = Console.ReadLine();
                
                Console.Write("Ingrese el email del entrenador: ");
                email = Console.ReadLine();
                
                Console.Write("Ingrese la fecha de nacimiento del entrenador: ");
                _ = DateTime.TryParse(Console.ReadLine(), out birthday);

                entrenador.Name = name;
                entrenador.Email = email;
                entrenador.Birthday = birthday;
                entrenador.Experience = 0;
                entrenador.WonBattles = 0;

                _asignamentSenamon = new AsignamentSenamon();
                _asignamentSenamon.asignamentSenamon();
                _asignamentSenamon.GetListSenamon();
                _asignamentSenamon.ShowAsignamentSenamon();
                
                entrenador.SetVectSenamon();
            }
        }
    }
}