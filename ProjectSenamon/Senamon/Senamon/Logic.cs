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
            if(this.ListTrainer[indexTrainer].Experience > 200)
            {
                
            }
        }
    }
}