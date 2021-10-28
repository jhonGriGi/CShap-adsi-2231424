using System;
using System.Collections.Generic;

namespace Senamon
{
    class Logic
    {
        public List<Trainer> ListTrainer = new List<Trainer>();

        // Constructor
        public Logic() {}

        // Methods
        public void SetListTrainer(int numTrainers)
        {
            Trainer trainer;
            AsignamentSenamon _asignamentSenamon = new AsignamentSenamon();

            string name, email;
            DateTime birthday;

            for(int i = 0; i < numTrainers; i++) 
            {
                trainer = new Trainer();

                Console.WriteLine("\n----------------------------");
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

                this.ListTrainer.Add(trainer);
            }
        }

        public void TrainingSenamon(int indexTrainer)
        {
            int trainSenamon, typeTraining, trainingConfirm;

            if(this.ListTrainer[indexTrainer].Experience > 200)
            {
                Console.WriteLine($"\nEntrenador {this.ListTrainer[indexTrainer].Name}.");
                Console.WriteLine("Puedes entrenar a un pokemon!!!");

                Console.WriteLine("\nElige el pokemon a entrenar");
                this.ListTrainer[indexTrainer].ShowTeamSenamon();

                do
                {
                    Console.Write("Ingresa el numero del Senamon a entrenar: ");
                    _ = int.TryParse(Console.ReadLine(), out trainSenamon);

                    if(trainSenamon < 0 && trainSenamon > this.ListTrainer[indexTrainer].GetVectSenamon().Length)
                        Console.WriteLine("Error, vuelve a ingresar el valor");

                } while(trainSenamon < 0 && trainSenamon > this.ListTrainer[indexTrainer].GetVectSenamon().Length);


                do
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.Write("Ingresa (1) si deseas entrenar o (2) para no: ");
                    _ = int.TryParse(Console.ReadLine(), out trainingConfirm);

                    if (trainingConfirm <= 0 || trainingConfirm > 2)
                        Console.WriteLine("Error, vuelve a introducir el valor");
                } while (trainingConfirm <= 0 || trainingConfirm > 2);

                if(trainingConfirm == 1)
                {
                    do
                    {
                        Console.Write("Ingrese 1 si quiere entrenar la salud,\nIngrese 2 si quiere entrenar el ataque: ");
                        _ = int.TryParse(Console.ReadLine(), out typeTraining);

                        if(typeTraining < 0)
                            Console.WriteLine("Error, vuelve a ingresar el valor");
                    } while(typeTraining < 0);

                    if(typeTraining == 1)
                    {
                        this.ListTrainer[indexTrainer].Experience -= 200;
                        this.ListTrainer[indexTrainer].GetVectSenamon()[trainSenamon].Health += 20;
                        Console.WriteLine($"El pokemon {this.ListTrainer[indexTrainer].GetVectSenamon()[trainSenamon].Name} ha sido entrenado!!!");
                    }
                    else 
                    {
                        this.ListTrainer[indexTrainer].Experience -= 200;
                        this.ListTrainer[indexTrainer].GetVectSenamon()[trainSenamon].Attack += 20;
                        Console.WriteLine($"El pokemon {this.ListTrainer[indexTrainer].GetVectSenamon()[trainSenamon].Name} ha sido entrenado!!!");
                    }
                } 
                else 
                {
                    Console.WriteLine($"\nEntrenador {this.ListTrainer[indexTrainer].Name}.");
                    Console.WriteLine("Ha decidido continuar la pelea");
                }
            }
            else
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine($"\nEntrenador {this.ListTrainer[indexTrainer].Name}.");
                Console.WriteLine("No tienes suficiente experiencia para entrenar");
                Console.WriteLine("----------------------------------------------------");
            }
        }
    }
}