using System;
using System.Collections.Generic;

namespace Senamon
{
    class Start
    {
        public List<Trainer> listTrainer = new List<Trainer>();
        
        public Start() { start(); }

        public List<Trainer> GetListTrainer() 
        {
            return this.listTrainer;
        }

        public void start() 
        {
            String name, email;
            DateTime birthday;

            Trainer trainer;
            AsignamentSenamon _asignamentSenamon = new AsignamentSenamon();

            int cantBatallas, respuesta1, respuesta2;
            
            int iterator = 0;

            while (iterator < 2)
            {
                trainer = new Trainer();
                
                Console.WriteLine("\n");
                Console.Write("Ingrese el nombre del entrenador: ");
                name = Console.ReadLine();
                
                Console.Write("Ingrese el email del entrenador: ");
                email = Console.ReadLine();
                
                Console.Write("Ingrese la fecha de nacimiento del entrenador: ");
                _ = DateTime.TryParse(Console.ReadLine(), out birthday);
                
                trainer.Name = name;
                trainer.Email = email;
                trainer.Birthday = birthday;
                trainer.Experience = 0;
                trainer.WonBattles = 0;

                _asignamentSenamon.GetListSenamon();
                _asignamentSenamon.ShowAsignamentSenamon();

                trainer.SetVectSenamon();

                this.listTrainer.Add(trainer);

                iterator++;
            }

            iterator = 0;
            Random random = new Random();

            int numRandom = random.Next(1, 11);


            Battle battle = new Battle();
            Training training = new Training();

            do
            {
                Console.Write("Ingresa la cantidad de veces que quieres pelear: ");
                _ = int.TryParse(Console.ReadLine(), out cantBatallas);

                if (cantBatallas <= 0)
                    Console.WriteLine("Error, vuelve a ingresar el valor");
    
            } while (cantBatallas <= 0);

            while(iterator < cantBatallas)
            {
                training.TrainingStart();

                battle.BattleStart(numRandom);

                training.TrainingStart();

                Console.WriteLine($"Entrenador {this.listTrainer[0].Name} quieres cambiar un senamon?");

                do
                {
                    Console.Write("Ingresa (1) si quieres cambiar o (2) si no: ");
                    _ = int.TryParse(Console.ReadLine(), out respuesta1);

                    if (respuesta1 <= 0)
                        Console.WriteLine("Error, vuelve a ingresar el valor");
                } while (respuesta1 <= 0);

                if (respuesta1 == 1)
                    this.listTrainer[0].ChangeSenamon();
                else
                    Console.WriteLine("Continua en el combate!!!");

                Console.WriteLine($"Entrenador {this.listTrainer[1].Name} quieres cambiar un senamon?");

                do
                {
                    Console.Write("Ingresa (1) si quieres cambiar o (2) si no: ");
                    _ = int.TryParse(Console.ReadLine(), out respuesta2);

                    if (respuesta2 <= 0)
                        Console.WriteLine("Error, vuelve a ingresar el valor");
                } while (respuesta2 <= 0);

                if (respuesta2 == 1)
                    this.listTrainer[1].ChangeSenamon();
                else
                    Console.WriteLine("Continua en el combate!!!");
            }

            Console.WriteLine($"La cantidad de victorias de {this.listTrainer[0].Name} es: {this.listTrainer[0].WonBattles}");
            Console.WriteLine($"La cantidad de victorias de {this.listTrainer[0].Name} es: {this.listTrainer[1].WonBattles}");
        }
    }
}