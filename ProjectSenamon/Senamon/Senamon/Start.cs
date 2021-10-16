using System;
using System.Collections.Generic;

namespace Senamon
{
    class Start
    {
        public List<Trainer> listTrainer = new List<Trainer>();
        
        public Start() {  }

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

            int respuesta1, respuesta2;
            
            for (int i = 0; i < 2; i++)
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

                if(i == 2)
                    break;
            }

            int continuaPelea;

            do 
            {
                // Entrenamiento
                // int EXPentrenador1 = this.listTrainer[0].Experience;
                // int EXPentrenador2 = this.listTrainer[1].Experience;
                int entrenamiento1, entrenamiento2, opcion, pokemon;

                if(this.listTrainer[0].Experience >= 200)
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine($"Entrenador {this.listTrainer[0].Name}, Tienes experiencia suficiente para entrenar!!!");
                    Console.WriteLine("-------------------------------------\n");

                    Console.WriteLine("-------------------------------------\n");
                    this.listTrainer[0].ShowTeamSenamon();
                    Console.WriteLine("-------------------------------------\n");

                    Console.WriteLine("\nIngresa el pokemon a entrenar");

                    do
                    {
                        Console.Write("   >>>Eleccion: ");
                        _ = int.TryParse(Console.ReadLine(), out pokemon);

                        if(pokemon < 0 || pokemon > 5)
                            Console.WriteLine("Error, vuelva a ingresar el valor");
                    } while (pokemon < 0 || pokemon > 5);

                    
                    do
                    {
                        Console.WriteLine("-------------------------------------\n");
                        Console.Write("Ingresa (1) si deseas entrenar o (2) para no: ");
                        _ = int.TryParse(Console.ReadLine(), out entrenamiento1);

                        if (entrenamiento1 <= 0 || entrenamiento1 > 2)
                            Console.WriteLine("Error, vuelve a introducir el valor");
                    } while (entrenamiento1 <= 0 || entrenamiento1 > 2);

                    if (entrenamiento1 == 1)
                    {
                        Console.WriteLine("-------------------------------------\n");
                        Console.WriteLine("Que quieres entrenar?");

                        do
                        {
                            Console.WriteLine("-------------------------------------\n");
                            Console.Write("Ingresa (1) si quieres entrenar la salud o (2) para el ataque: ");
                            _ = int.TryParse(Console.ReadLine(), out opcion);

                            if (opcion <= 0 || opcion > 2)
                                Console.WriteLine("Error, ingrese nuevamente el valor");
                        } while (opcion <= 0 || opcion > 2);

                        if (opcion == 1)
                        {
                            this.listTrainer[0].Experience -= 200;
                            this.listTrainer[0].GetVectSenamon()[pokemon].Health += 20;
                            Console.WriteLine("-------------------------------------\n");
                            Console.WriteLine("Senamon entrenado!!!");
                            Console.WriteLine("-------------------------------------\n");
                        }
                        else
                        {
                            this.listTrainer[0].Experience -= 200;
                            this.listTrainer[0].GetVectSenamon()[pokemon].Attack += 20;
                            Console.WriteLine("-------------------------------------\n");
                            Console.WriteLine("Senamon entrenado!!!");
                            Console.WriteLine("-------------------------------------\n");
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine($"Entrenador {this.listTrainer[0].Name}, No tienes suficiente experiencia para entrenar");

                    Console.WriteLine($"\n   >>>>EXP: {this.listTrainer[0].Experience}");
                    Console.WriteLine("-------------------------------------\n");
                }

                if(this.listTrainer[1].Experience >= 200)
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine($"Entrenador {this.listTrainer[1].Name}, Tienes experiencia suficiente para entrenar!!!");
                    Console.WriteLine("-------------------------------------\n");

                    Console.WriteLine("-------------------------------------\n");
                    this.listTrainer[1].ShowTeamSenamon();
                    Console.WriteLine("-------------------------------------\n");

                    Console.WriteLine("\nIngresa el pokemon a entrenar");

                    do
                    {
                        Console.Write("   >>>Eleccion: ");
                        _ = int.TryParse(Console.ReadLine(), out pokemon);

                        if(pokemon < 0 || pokemon > 5)
                            Console.WriteLine("Error, vuelva a ingresar el valor");
                    } while (pokemon < 0 || pokemon > 5);

                    
                    do
                    {
                        Console.WriteLine("-------------------------------------\n");
                        Console.Write("Ingresa (1) si deseas entrenar o (2) para no: ");
                        _ = int.TryParse(Console.ReadLine(), out entrenamiento2);

                        if (entrenamiento2 <= 0 || entrenamiento2 > 2)
                            Console.WriteLine("Error, vuelve a introducir el valor");
                    } while (entrenamiento2 <= 0 || entrenamiento2 > 2);

                    if (entrenamiento2 == 1)
                    {
                        Console.WriteLine("Que quieres entrenar?");

                        do
                        {
                            Console.WriteLine("-------------------------------------\n");
                            Console.Write("Ingresa (1) si quieres entrenar la salud o (2) para el ataque: ");
                            _ = int.TryParse(Console.ReadLine(), out opcion);

                            if (opcion <= 0 || opcion > 2)
                                Console.WriteLine("Error, ingrese nuevamente el valor");
                        } while (opcion <= 0 || opcion > 2);

                        if (opcion == 1)
                        {
                            this.listTrainer[1].Experience -= 200;
                            this.listTrainer[1].GetVectSenamon()[pokemon].Health += 20;
                            Console.WriteLine("-------------------------------------\n");
                            Console.WriteLine("Senamon entrenado!!!");
                            Console.WriteLine("-------------------------------------\n");
                        }
                        else
                        {

                            this.listTrainer[1].Experience -= 200;
                            this.listTrainer[1].GetVectSenamon()[pokemon].Attack += 20;
                            Console.WriteLine("-------------------------------------\n");
                            Console.WriteLine("Senamon entrenado!!!");
                            Console.WriteLine("-------------------------------------\n");
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine($"Entrenador {this.listTrainer[1].Name}, No tienes suficiente experiencia para entrenar");

                    Console.WriteLine($"\n   >>>>EXP: {this.listTrainer[1].Experience}");
                    Console.WriteLine("-------------------------------------\n");
                }
                
                Console.WriteLine("-------------------------------------\n");
                this.listTrainer[0].ShowTeamSenamon();
                Console.WriteLine("-------------------------------------\n");

                Console.WriteLine("-------------------------------------\n");
                Console.WriteLine($"Entrenador {this.listTrainer[0].Name} quieres cambiar un senamon?");
                Console.WriteLine("-------------------------------------\n");

                do
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.Write("Ingresa (1) si quieres cambiar o (2) si no: ");
                    _ = int.TryParse(Console.ReadLine(), out respuesta1);

                    if (respuesta1 <= 0)
                        Console.WriteLine("Error, vuelve a ingresar el valor");
                } while (respuesta1 <= 0);

                if (respuesta1 == 1)
                {
                    this.listTrainer[0].ShowTeamSenamon();
                    this.listTrainer[0].ChangeSenamon();
                    this.listTrainer[0].ShowTeamSenamon();
                }
                else
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine("Comienza el COMBATE!!!");
                    Console.WriteLine("-------------------------------------\n");
                }

                Console.WriteLine("-------------------------------------\n");
                this.listTrainer[1].ShowTeamSenamon();
                Console.WriteLine("-------------------------------------\n");

                Console.WriteLine("-------------------------------------\n");
                Console.WriteLine($"Entrenador {this.listTrainer[1].Name} quieres cambiar un senamon?");
                Console.WriteLine("-------------------------------------\n");

                do
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.Write("Ingresa (1) si quieres cambiar o (2) si no: ");
                    _ = int.TryParse(Console.ReadLine(), out respuesta2);

                    if (respuesta2 <= 0)
                        Console.WriteLine("Error, vuelve a ingresar el valor");
                } while (respuesta2 <= 0);

                if (respuesta2 == 1)
                {
                    this.listTrainer[1].ShowTeamSenamon();
                    this.listTrainer[1].ChangeSenamon();
                    this.listTrainer[1].ShowTeamSenamon();
                }
                else
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine("Comienza el COMBATE!!!");
                    Console.WriteLine("-------------------------------------\n");
                }


                //
                // Pelea
                int maxLength = this.listTrainer[0].GetVectSenamon().Length;

                Random random = new Random();

                int numRandom = random.Next(1, 11);

                int pokemon1, pokemon2;    
                bool entrenador1Start;  

                if (numRandom % 2 != 0)
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine($"Entranador {this.listTrainer[0].Name} empieza");
                    Console.WriteLine("-------------------------------------\n");

                    

                    do
                    {
                        Console.WriteLine($"Entrenador {this.listTrainer[0].Name}!!!");
                        Console.WriteLine("-------------------------------------\n");
                        this.listTrainer[0].ShowTeamSenamon();
                        Console.WriteLine("-------------------------------------\n");
                        Console.Write("Ingresa el pokemon para la batalla: ");
                        _ = int.TryParse(Console.ReadLine(), out pokemon1);

                        if(pokemon1 < 0 || pokemon1 > maxLength)
                            Console.WriteLine("Error, vuelve a ingresar el valor");
                        
                    } while (pokemon1 < 0 || pokemon1 > maxLength);


                    do
                    {
                        Console.WriteLine($"Entrenador {this.listTrainer[1].Name}!!!");
                        Console.WriteLine("-------------------------------------\n");
                        this.listTrainer[1].ShowTeamSenamon();
                        Console.WriteLine("-------------------------------------\n");
                        Console.Write("Ingresa el pokemon para la batalla: ");
                        _ = int.TryParse(Console.ReadLine(), out pokemon2);

                        if(pokemon2 < 0 || pokemon2 > maxLength)
                            Console.WriteLine("Error, vuelve a ingresar el valor");
                        
                    } while (pokemon2 < 0 || pokemon2 > maxLength);

                    entrenador1Start = true;
                }
                else 
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine($"Entranador {this.listTrainer[1].Name} empieza");
                    Console.WriteLine("-------------------------------------\n");
                    do
                    {
                        Console.WriteLine($"Entrenador {this.listTrainer[0].Name}!!!");
                        Console.WriteLine("-------------------------------------\n");
                        this.listTrainer[0].ShowTeamSenamon();
                        Console.WriteLine("-------------------------------------\n");
                        Console.Write("Ingresa el pokemon para la batalla: ");
                        _ = int.TryParse(Console.ReadLine(), out pokemon1);

                        if(pokemon1 < 0 || pokemon1 > maxLength)
                            Console.WriteLine("Error, vuelve a ingresar el valor");
                        
                    } while (pokemon1 < 0 || pokemon1 > maxLength);

                    do
                    {
                        Console.WriteLine($"Entrenador {this.listTrainer[1].Name}!!!");
                        Console.WriteLine("-------------------------------------\n");
                        this.listTrainer[1].ShowTeamSenamon();
                        Console.WriteLine("-------------------------------------\n");
                        Console.Write("Ingresa el pokemon para la batalla: ");
                        _ = int.TryParse(Console.ReadLine(), out pokemon2);

                        if(pokemon2 < 0 || pokemon2 > maxLength)
                            Console.WriteLine("Error, vuelve a ingresar el valor");
                        
                    } while (pokemon2 < 0 || pokemon2 > maxLength);

                    entrenador1Start = false;
                }

                Senamon senamon1 = this.listTrainer[0].GetVectSenamon()[pokemon1];
                Senamon senamon2 = this.listTrainer[1].GetVectSenamon()[pokemon2];

                Trainer entrenador1 = this.listTrainer[0];
                Trainer entrenador2 = this.listTrainer[1];

                int turno = 0;
                int VictoriasEnt1 = 0, VictoriasEnt2 = 2;
                int victoriaEnt1 = this.listTrainer[0].WonBattles;
                int victoriaEnt2 = this.listTrainer[1].WonBattles;

                while (VictoriasEnt1 < 3 && VictoriasEnt2 < 3)
                {
                    if (entrenador1Start)
                    {
                        while (senamon1.Health > 0 && senamon2.Health > 0)
                        {
                            if (turno == 0)
                            {
                                senamon2.Health -= senamon1.Attack;
                                Console.WriteLine("-------------------------------------\n");
                                Console.WriteLine($"El Senamon {senamon1.Name} ha atacado a {senamon2.Name}");
                                Console.WriteLine("-------------------------------------\n");
                            }
                            else if(turno == 1)
                            {
                                senamon1.Health -= senamon2.Attack;
                                Console.WriteLine("-------------------------------------\n");
                                Console.WriteLine($"El Senamon {senamon2.Name} ha atacado a {senamon1.Name}");
                                Console.WriteLine("-------------------------------------\n");
                            }

                            turno++;
                            if (turno > 1)
                                turno = 0;
                        }
                        
                    }
                    else
                    {
                        while (senamon1.Health > 0 && senamon2.Health > 0)
                        {
                            if (turno == 0)
                            {
                                senamon1.Health -= senamon2.Attack;
                                Console.WriteLine("-------------------------------------\n");
                                Console.WriteLine($"El Senamon {senamon2.Name} ha atacado a {senamon1.Name}");
                                Console.WriteLine("-------------------------------------\n");
                            }
                            else if(turno == 1)
                            {
                                senamon2.Health -= senamon1.Attack;
                                Console.WriteLine("-------------------------------------\n");
                                Console.WriteLine($"EL pokemon {senamon1.Name} ha atacado a {senamon2.Name}");
                                Console.WriteLine("-------------------------------------\n");
                            }

                            turno++;
                            if (turno == 2)
                                turno = 0;
                        }
                    }
                    if (senamon1.Health <= 0)
                    {
                        VictoriasEnt2 += 1;

                        Console.WriteLine("-------------------------------------\n");
                        Console.WriteLine($"El Senamon {senamon1.Name} ha MUERTO!!!");
                        Console.WriteLine("-------------------------------------\n");

                        do
                        {
                            Console.WriteLine($"Entrenador {this.listTrainer[0].Name}!!!");
                            Console.WriteLine("-------------------------------------\n");
                            this.listTrainer[0].ShowTeamSenamon();
                            Console.WriteLine("-------------------------------------\n");
                            Console.Write("Ingresa otro pokemon para la batalla: ");
                            _ = int.TryParse(Console.ReadLine(), out pokemon1);

                            if(pokemon1 < 0 || pokemon1 > maxLength)
                                Console.WriteLine("Error, vuelve a ingresar el valor");
                            
                        } while (pokemon1 < 0 || pokemon1 > maxLength);

                        senamon1 = this.listTrainer[0].GetVectSenamon()[pokemon1];

                    }
                    else if(senamon2.Health <= 0)
                    {
                        VictoriasEnt1 += 1;

                        this.listTrainer[0].WonBattles += 1;

                        Console.WriteLine("-------------------------------------\n");
                        Console.WriteLine($"El Senamon {senamon2.Name} ha MUERTO!!!");
                        Console.WriteLine("-------------------------------------\n");


                        do
                        {
                            Console.WriteLine($"Entrenador {this.listTrainer[1].Name}!!!");
                            Console.WriteLine("-------------------------------------\n");
                            this.listTrainer[1].ShowTeamSenamon();
                            Console.WriteLine("-------------------------------------\n");
                            Console.Write("Ingresa otro pokemon para la batalla: ");
                            _ = int.TryParse(Console.ReadLine(), out pokemon2);

                            if(pokemon2 < 0 || pokemon2 > maxLength)
                                Console.WriteLine("Error, vuelve a ingresar el valor");
                            
                        } while (pokemon2 < 0 || pokemon2 > maxLength);

                        senamon2 = this.listTrainer[1].GetVectSenamon()[pokemon2];
                    }
                    if(VictoriasEnt1 == 3)
                    {
                        victoriaEnt1 += 1;

                        Console.WriteLine("-------------------------------------\n");
                        Console.WriteLine($"El entrenador {this.listTrainer[0].Name}. Ha ganado y ha conseguido 100 de EXP");
                        Console.WriteLine("-------------------------------------\n");

                        this.listTrainer[0].Experience += 100;
                    }
                    else if(VictoriasEnt2 == 3)
                    {
                        victoriaEnt2 += 1;

                        this.listTrainer[1].WonBattles += 1;

                        Console.WriteLine("-------------------------------------\n");
                        Console.WriteLine($"El entrenador {this.listTrainer[1].Name}. Ha ganado y ha conseguido 100 de EXP");
                        Console.WriteLine("-------------------------------------\n");

                        this.listTrainer[1].Experience += 100;
                    }                    
                }
                //
                
                // entrenamient 2 
                if(this.listTrainer[0].Experience >= 200)
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine($"Entrenador {this.listTrainer[0].Name}, Tienes experiencia suficiente para entrenar!!!");
                    Console.WriteLine("-------------------------------------\n");

                    Console.WriteLine("-------------------------------------\n");
                    this.listTrainer[0].ShowTeamSenamon();
                    Console.WriteLine("-------------------------------------\n");

                    Console.WriteLine("\nIngresa el pokemon a entrenar");

                    do
                    {
                        Console.Write("   >>>Eleccion: ");
                        _ = int.TryParse(Console.ReadLine(), out pokemon);

                        if(pokemon < 0 || pokemon > 5)
                            Console.WriteLine("Error, vuelva a ingresar el valor");
                    } while (pokemon < 0 || pokemon > 5);

                    
                    do
                    {
                        Console.WriteLine("-------------------------------------\n");
                        Console.Write("Ingresa (1) si deseas entrenar o (2) para no: ");
                        _ = int.TryParse(Console.ReadLine(), out entrenamiento1);

                        if (entrenamiento1 <= 0 || entrenamiento1 > 2)
                            Console.WriteLine("Error, vuelve a introducir el valor");
                    } while (entrenamiento1 <= 0 || entrenamiento1 > 2);

                    if (entrenamiento1 == 1)
                    {
                        Console.WriteLine("-------------------------------------\n");
                        Console.WriteLine("Que quieres entrenar?");
                        Console.WriteLine("-------------------------------------\n");

                        do
                        {
                            Console.WriteLine("-------------------------------------\n");
                            Console.Write("Ingresa (1) si quieres entrenar la salud o (2) para el ataque: ");
                            _ = int.TryParse(Console.ReadLine(), out opcion);

                            if (opcion <= 0 || opcion > 2)
                                Console.WriteLine("Error, ingrese nuevamente el valor");
                        } while (opcion <= 0 || opcion > 2);

                        if (opcion == 1)
                        {
                            this.listTrainer[0].Experience -= 200;
                            this.listTrainer[0].GetVectSenamon()[pokemon].Health += 20;
                            Console.WriteLine("-------------------------------------\n");
                            Console.WriteLine("Senamon entrenado!!!");
                            Console.WriteLine("-------------------------------------\n");
                        }
                        else
                        {
                            this.listTrainer[0].Experience -= 200;
                            this.listTrainer[0].GetVectSenamon()[pokemon].Attack += 20;
                            Console.WriteLine("-------------------------------------\n");
                            Console.WriteLine("Senamon entrenado!!!");
                            Console.WriteLine("-------------------------------------\n");

                        }
                    }
                }
                else 
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine($"Entrenador {this.listTrainer[0].Name}, No tienes suficiente experiencia para entrenar");

                    Console.WriteLine($"\n   >>>>EXP: {this.listTrainer[0].Experience}");
                    Console.WriteLine("-------------------------------------\n");
                }

                if(this.listTrainer[1].Experience >= 200)
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine($"Entrenador {this.listTrainer[1].Name}, Tienes experiencia suficiente para entrenar!!!");
                    Console.WriteLine("-------------------------------------\n");

                    Console.WriteLine("-------------------------------------\n");
                    this.listTrainer[1].ShowTeamSenamon();
                    Console.WriteLine("-------------------------------------\n");

                    Console.WriteLine("\nIngresa el pokemon a entrenar");

                    do
                    {
                        Console.Write("   >>>Eleccion: ");
                        _ = int.TryParse(Console.ReadLine(), out pokemon);

                        if(pokemon < 0 || pokemon > 5)
                            Console.WriteLine("Error, vuelva a ingresar el valor");
                    } while (pokemon < 0 || pokemon > 5);

                    
                    do
                    {
                    Console.WriteLine("-------------------------------------\n");
                        Console.Write("Ingresa (1) si deseas entrenar o (2) para no: ");
                        _ = int.TryParse(Console.ReadLine(), out entrenamiento2);

                        if (entrenamiento2 <= 0 || entrenamiento2 > 2)
                            Console.WriteLine("Error, vuelve a introducir el valor");
                    } while (entrenamiento2 <= 0 || entrenamiento2 > 2);

                    if (entrenamiento2 == 1)
                    {
                        Console.WriteLine("-------------------------------------\n");
                        Console.WriteLine("Que quieres entrenar?");
                        Console.WriteLine("-------------------------------------\n");

                        do
                        {
                            Console.WriteLine("-------------------------------------\n");
                            Console.Write("Ingresa (1) si quieres entrenar la salud o (2) para el ataque: ");
                            _ = int.TryParse(Console.ReadLine(), out opcion);

                            if (opcion <= 0 || opcion > 2)
                                Console.WriteLine("Error, ingrese nuevamente el valor");
                        } while (opcion <= 0 || opcion > 2);

                        if (opcion == 1)
                        {
                            this.listTrainer[1].Experience -= 200;
                            this.listTrainer[1].GetVectSenamon()[pokemon].Health += 20;
                            Console.WriteLine("-------------------------------------\n");
                            Console.WriteLine("Senamon entrenado!!!");
                            Console.WriteLine("-------------------------------------\n");
                        }
                        else
                        {
                            this.listTrainer[1].Experience -= 200;
                            this.listTrainer[1].GetVectSenamon()[pokemon].Attack += 20;
                            Console.WriteLine("-------------------------------------\n");
                            Console.WriteLine("Senamon entrenado!!!");
                            Console.WriteLine("-------------------------------------\n");
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine($"Entrenador {this.listTrainer[1].Name}, No tienes suficiente experiencia para entrenar");

                    Console.WriteLine($"\n   >>>>EXP: {this.listTrainer[1].Experience}");
                    Console.WriteLine("-------------------------------------\n");
                }
                
                Console.WriteLine("-------------------------------------\n");   
                this.listTrainer[0].ShowTeamSenamon();
                Console.WriteLine("-------------------------------------\n");

                Console.WriteLine("-------------------------------------\n");
                Console.WriteLine($"Entrenador {this.listTrainer[0].Name} quieres cambiar un senamon?");
                Console.WriteLine("-------------------------------------\n");

                do
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.Write("Ingresa (1) si quieres cambiar o (2) si no: ");
                    _ = int.TryParse(Console.ReadLine(), out respuesta1);

                    if (respuesta1 <= 0)
                        Console.WriteLine("Error, vuelve a ingresar el valor");
                } while (respuesta1 <= 0);

                if (respuesta1 == 1)
                {
                    this.listTrainer[0].ShowTeamSenamon();
                    this.listTrainer[0].ChangeSenamon();
                    this.listTrainer[0].ShowTeamSenamon();
                }
                else
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine("Continua en el combate!!!");
                    Console.WriteLine("-------------------------------------\n");
                }   

                Console.WriteLine("-------------------------------------\n");
                this.listTrainer[1].ShowTeamSenamon();
                Console.WriteLine("-------------------------------------\n");
                
                Console.WriteLine("-------------------------------------\n");
                Console.WriteLine($"Entrenador {this.listTrainer[1].Name} quieres cambiar un senamon?");
                Console.WriteLine("-------------------------------------\n");

                do
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.Write("Ingresa (1) si quieres cambiar o (2) si no: ");
                    _ = int.TryParse(Console.ReadLine(), out respuesta2);

                    if (respuesta2 <= 0)
                        Console.WriteLine("Error, vuelve a ingresar el valor");
                } while (respuesta2 <= 0);

                if (respuesta2 == 1)
                {
                    this.listTrainer[1].ShowTeamSenamon();
                    this.listTrainer[1].ChangeSenamon();
                    this.listTrainer[1].ShowTeamSenamon();
                }
                else
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine("Continua en el combate!!!");
                    Console.WriteLine("-------------------------------------\n");
                }


                do 
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.Write("Ingresa 1 si quieres volver a pelear de lo contrario ingresa 2: ");
                    _ = int.TryParse(Console.ReadLine(), out  continuaPelea);

                    if (continuaPelea <= 0 || continuaPelea > 2)
                        Console.WriteLine("Error, vuelve a ingresar el valor");
                } while (continuaPelea <= 0 || continuaPelea > 2);

            } while (continuaPelea == 1);

            Console.WriteLine($"La cantidad de victorias de {this.listTrainer[0].Name} es: {this.listTrainer[0].WonBattles}");
            Console.WriteLine($"La cantidad de victorias de {this.listTrainer[1].Name} es: {this.listTrainer[1].WonBattles}");
        }
    }
}