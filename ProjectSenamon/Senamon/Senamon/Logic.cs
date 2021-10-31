using System;
using System.Collections.Generic;

namespace Senamon
{
    class Logic
    {
        public List<Trainer> ListTrainer = new List<Trainer>();
        
        public AsignamentSenamon _asignamentSenamon;

        // Constructor
        public Logic() {}

        // Methods
        public void SetListTrainer(int numTrainers)
        {
            Trainer trainer;
            AsignamentSenamon _asignamentSenamon = new AsignamentSenamon();

            string name, email;
            DateTime birthday;

            for (int i = 0; i < numTrainers; i++) 
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
                trainer.Experience = 400;
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

            if (this.ListTrainer[indexTrainer].Experience >= 200)
            {
                Console.WriteLine($"\nEntrenador {this.ListTrainer[indexTrainer].Name}.");
                Console.WriteLine("Puedes entrenar a un pokemon!!!");

                Console.WriteLine("\nElige el pokemon a entrenar");
                this.ListTrainer[indexTrainer].ShowTeamSenamon();

                do
                {
                    Console.Write("Ingresa el numero del Senamon a entrenar: ");
                    _ = int.TryParse(Console.ReadLine(), out trainSenamon);

                    if (trainSenamon < 0 && trainSenamon > this.ListTrainer[indexTrainer].GetVectSenamon().Length)
                        Console.WriteLine("Error, vuelve a ingresar el valor");

                } while (trainSenamon < 0 && trainSenamon > this.ListTrainer[indexTrainer].GetVectSenamon().Length);


                do
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.Write("Ingresa (1) si deseas entrenar o (2) para no: ");
                    _ = int.TryParse(Console.ReadLine(), out trainingConfirm);

                    if (trainingConfirm <= 0 || trainingConfirm > 2)
                        Console.WriteLine("Error, vuelve a introducir el valor");
                } while (trainingConfirm <= 0 || trainingConfirm > 2);

                if (trainingConfirm == 1)
                {
                    do
                    {
                        Console.Write("Ingrese 1 si quiere entrenar la salud,\nIngrese 2 si quiere entrenar el ataque: ");
                        _ = int.TryParse(Console.ReadLine(), out typeTraining);

                        if (typeTraining < 0)
                            Console.WriteLine("Error, vuelve a ingresar el valor");
                    } while (typeTraining < 0);

                    if (typeTraining == 1)
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

        public bool GetRandomNumber()
        {
            Random random = new Random();
            
            int numberRandom = random.Next(0, 11);

            return numberRandom % 2 == 0 ? true : false;
        }


        // metodo para el cambio de senamones si estan muertos 
        public void ChangeSenamonDead(int indexTrainer)
        {
            int option;

            for (int i = 0; i < 5; i++)
            {
                if (this.ListTrainer[indexTrainer].GetVectSenamon()[i].Health <= 0)
                {
                    Console.WriteLine($"El Senamon {this.ListTrainer[indexTrainer].GetVectSenamon()[i].Name}. Ha muerto");
                    Console.WriteLine("Debes cambiar de senamon");

                    _asignamentSenamon.ShowAsignamentSenamon();

                    do
                    {
                        Console.Write("Ingresa el numero del nuevo senamon para tu equipo: ");
                        _ = int.TryParse(Console.ReadLine(), out option);

                        if (option < 0 || option > _asignamentSenamon.GetListSenamon().Count -1)
                            Console.WriteLine("Error, vuelve a introducir el valor");
                        
                    } while (option < 0 || option > _asignamentSenamon.GetListSenamon().Count -1);

                    this.ListTrainer[indexTrainer].GetVectSenamon()[i] = _asignamentSenamon.GetListSenamon()[option];
                }
            }
        }
        public int ChooseSenamon(int indexTrainer)
        {
            int indexSenamon; 

            Console.WriteLine("-------------------------------------\n");
            Console.WriteLine($"Entranador {this.ListTrainer[indexTrainer].Name}. EL combate empieza");
            Console.WriteLine("---------------------------------------");

            ChangeSenamonDead(indexTrainer);

            do
            {
                Console.WriteLine($"\nEntrenador {this.ListTrainer[indexTrainer].Name}. Elige un Senamon para el combate\n");
                this.ListTrainer[indexTrainer].ShowTeamSenamon();
                Console.Write($"\nIngresa el pokemon para la batalla: ");
                _ = int.TryParse(Console.ReadLine(), out indexSenamon);

                if (indexSenamon < 0 || indexSenamon > 5)
                        Console.WriteLine("Error, vuelve a ingresar el valor");
            } while (indexSenamon < 0 || indexSenamon > 5);

            return indexSenamon;
            
        }

        // TODO: hacer un refactor de las peleas 
        public void BasicBattle()
        {
            int victory1 = 0, victory2 = 0, fightVictory1 = 0, fightVictory2 = 0;
            int indexSenamon1 = ChooseSenamon(1);
            int indexSenamon2 = ChooseSenamon(2);
            bool firstTrainer = GetRandomNumber();

            while (victory1 < 3 && victory2 < 3) 
            { 
                for (int i = 0; i < 2; i++)
                    TrainingSenamon(i);
                    
                if (firstTrainer)
                {
                    fightVictory1 = TypeBattle(1, indexSenamon1, 2, indexSenamon2);
                    fightVictory2 = TypeBattle(2, indexSenamon2, 1, indexSenamon1);

                    if (fightVictory1 == 3)
                        victory1++;
                    else if (fightVictory2 == 3)
                        victory2++;
                }
                else 
                {
                    fightVictory2 = TypeBattle(2, indexSenamon2, 1, indexSenamon1);
                    fightVictory1 = TypeBattle(1, indexSenamon1, 2, indexSenamon2);

                    if (fightVictory1 == 3)
                        victory1++;
                    else if (fightVictory2 == 3)
                        victory2++;
                }
                
            }
        }


        public void Tournment()
        {
            int victory1 = 0, victory2 = 0, victory3 = 0, victory4 = 0;
            int fightVictory1 = 0, fightVictory2 = 0, fightVictory3 = 0, fightVictory4 = 0;
            int indexSenamon1 = ChooseSenamon(1);
            int indexSenamon2 = ChooseSenamon(2);
            int indexSenamon3 = ChooseSenamon(3);
            int indexSenamon4 = ChooseSenamon(3);

            bool firstTrainer1 = GetRandomNumber();
            bool firstTrainer2 = GetRandomNumber();
            bool firstTrainer3 = GetRandomNumber();
            bool firstTrainer4 = GetRandomNumber();

            while (victory1 < 3 && victory2 < 3) 
            {
                for (int i = 0; i < 2; i++)
                    TrainingSenamon(i);
                    
                if (firstTrainer1)
                {
                    fightVictory1 = TypeBattle(1, indexSenamon1, 2, indexSenamon2);
                    fightVictory2 = TypeBattle(2, indexSenamon2, 1, indexSenamon1);

                    if (fightVictory1 == 3)
                        victory1++;
                    else if (fightVictory2 == 3)
                        victory2++;
                }
                else
                {
                    fightVictory2 = TypeBattle(2, indexSenamon2, 1, indexSenamon2);
                    fightVictory1 = TypeBattle(1, indexSenamon1, 2, indexSenamon2);

                    if (fightVictory1 == 3)
                        victory1++;
                    else if (fightVictory2 == 3)
                        victory2++;
                }
                
            }

            while (victory3 < 3 && victory4 < 3)
            {
                for (int i = 3; i <= 4; i++)
                    TrainingSenamon(i);

                if (firstTrainer2)
                {
                    fightVictory3 = TypeBattle(3, indexSenamon3, 4, indexSenamon4);
                    fightVictory4 = TypeBattle(4, indexSenamon4, 3, indexSenamon3);

                    if (fightVictory3 == 3)
                        victory3++;
                    else if (fightVictory4 == 4)
                        victory4++;
                }
                else 
                {
                    fightVictory4 = TypeBattle(4, indexSenamon4, 3, indexSenamon3);
                    fightVictory3 = TypeBattle(3, indexSenamon3, 4, indexSenamon4);

                    if (fightVictory3 == 3)
                        victory3++;
                    else if (fightVictory4 == 4)
                        victory4++;
                }
            }

            while (victory1 < 3 && victory4 < 3)
            {
                TrainingSenamon(1);
                TrainingSenamon(4);

                if (firstTrainer3)
                {
                    fightVictory1 = TypeBattle(1, indexSenamon1, 4, indexSenamon4);
                    fightVictory4 = TypeBattle(4, indexSenamon4, 1, indexSenamon1);

                    if (fightVictory1 == 3)
                        victory1++;
                    else if (fightVictory4 == 3)
                        victory4++;
                }
                else 
                {
                    fightVictory4 = TypeBattle(4, indexSenamon4, 1, indexSenamon1);
                    fightVictory1 = TypeBattle(1, indexSenamon1, 4, indexSenamon4);

                    if (fightVictory1 == 3)
                        victory1++;
                    else if (fightVictory4 == 3)
                        victory4++;
                }
            }

            while (victory2 < 3 && victory3 < 3)
            {
                for (int i = 2; i <= 3; i++)
                    TrainingSenamon(i);

                if (firstTrainer4)
                {
                    fightVictory2 = TypeBattle(2, indexSenamon2, 3, indexSenamon3);
                    fightVictory3 = TypeBattle(3, indexSenamon3, 2, indexSenamon2);

                    if (fightVictory2 == 3)
                        victory2++;
                    else if (fightVictory3 == 3)
                        victory3++;
                }
                else
                {
                    fightVictory3 = TypeBattle(3, indexSenamon3, 2, indexSenamon2);
                    fightVictory2 = TypeBattle(2, indexSenamon2, 3, indexSenamon3);

                    if (fightVictory2 == 3)
                        victory2++;
                    else if (fightVictory3 == 3)
                        victory3++;
                }
                
            }
        }

        // metodo para las bonificaciones de dmg 
        // TODO: Refactorizar el metodo typeBattle para recibir un contador de victorias
        public int TypeBattle(int indexTrainer1, int indexSenamon1, int indexTrainer2, int indexSenamon2)
        {
            int porcentaje;
            int fightVictory = 0;

            switch (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].TypeSenamon)
            {
                case "Planta":
                    switch (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].TypeSenamon)
                    {
                        case "Fuego":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Normal");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }

                            break;
                        
                        case "Agua":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 2);

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Super Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Planta":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 10) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Poco Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Volador":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 10) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Poco Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Electrico":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 40) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;
                    }

                    break;

                case "Agua":
                    switch (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].TypeSenamon)
                    {
                        case "Fuego":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 2);

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Super Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;
                        
                        case "Agua":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 10) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Poco Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Planta":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 10) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Poco Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Volador":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 40) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Electrico":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Normal");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;
                    }

                    break;

                case "Fuego":
                    switch (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].TypeSenamon)
                    {
                        case "Fuego":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 10) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido poco Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;
                        
                        case "Agua":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 10) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Poco Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Planta":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 40) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Volador":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Normal");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Electrico":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 2);

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Super Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;
                    }

                    break;
                case "Bicho":
                    switch (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].TypeSenamon)
                    {
                        case "Fuego":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Normal");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;
                        
                        case "Agua":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 10) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Poco Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Planta":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 2);

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Super Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Volador":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Normal");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Electrico":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 10) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Poco Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;
                    }

                    break;

                case "Volador":
                    switch (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].TypeSenamon)
                    {
                        case "Fuego":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Normal");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;
                        
                        case "Agua":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 40) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Planta":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 2);

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Super Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Volador":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 10) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Poco Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Electrico":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 10) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Poco Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;
                    }

                    break;

                case "Normal":
                    switch (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].TypeSenamon)
                    {
                        case "Fuego":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Normal");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;
                        
                        case "Agua":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Normal");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Planta":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Normal");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Volador":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Normal");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Electrico":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Normal");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;
                    }

                    break;

                case "Electrico":
                    switch (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].TypeSenamon)
                    {
                        case "Fuego":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 10) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Poco Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;
                        
                        case "Agua":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Normal");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Planta":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 40) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Volador":
                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 2);

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Super Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;

                        case "Electrico":
                            porcentaje = (this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Attack * 10) / 100;

                            this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health -= porcentaje;

                            Console.WriteLine($"El ataque del senamon {this.ListTrainer[indexTrainer1].GetVectSenamon()[indexSenamon1].Name}. Ha sido Poco Efectivo");

                            if (this.ListTrainer[indexTrainer2].GetVectSenamon()[indexSenamon2].Health <= 0)
                            {
                                fightVictory += 1;
                                this.ListTrainer[indexTrainer1].WonBattles += 1;
                                ChangeSenamonDead(indexTrainer2);
                            }
                               
                            break;
                    }

                    break;
            }
            
            return fightVictory;
        }

    }
}