using System;
using System.Collections.Generic;

namespace Senamon
{
    class Battle 
    {
        public Battle() {  }

        public void BattleStart()
        {
            Start start = new Start();
            int maxLength = start.GetListTrainer()[0].GetVectSenamon().Length;

            Random random = new Random();

            int numRandom = random.Next(1, 11);

            int pokemon1, pokemon2;    
            bool entrenador1Start;      

            if (numRandom % 2 != 0)
            {
                Console.WriteLine($"Entranador {start.listTrainer[0].Name} empieza");

                start.GetListTrainer()[0].ShowTeamSenamon();

                do
                {
                    Console.WriteLine($"Entrenador {start.listTrainer[0].Name}!!!");
                    Console.Write("Ingresa el pokemon para la batalla: ");
                    _ = int.TryParse(Console.ReadLine(), out pokemon1);

                    if(pokemon1 < 0 || pokemon1 > maxLength)
                        Console.WriteLine("Error, vuelve a ingresar el valor");
                    
                } while (pokemon1 < 0 || pokemon1 > maxLength);

                start.GetListTrainer()[1].ShowTeamSenamon();

                do
                {
                    Console.WriteLine($"Entrenador {start.listTrainer[1].Name}!!!");
                    Console.Write("Ingresa el pokemon para la batalla: ");
                    _ = int.TryParse(Console.ReadLine(), out pokemon2);

                    if(pokemon2 < 0 || pokemon2 > maxLength)
                        Console.WriteLine("Error, vuelve a ingresar el valor");
                    
                } while (pokemon2 < 0 || pokemon2 > maxLength);

                entrenador1Start = true;
            }
            else 
            {
                Console.WriteLine($"Entranador {start.listTrainer[1].Name} empieza");
                    do
                {
                    Console.WriteLine($"Entrenador {start.listTrainer[0].Name}!!!");
                    Console.Write("Ingresa el pokemon para la batalla: ");
                    _ = int.TryParse(Console.ReadLine(), out pokemon1);

                    if(pokemon1 < 0 || pokemon1 > maxLength)
                        Console.WriteLine("Error, vuelve a ingresar el valor");
                    
                } while (pokemon1 < 0 || pokemon1 > maxLength);

                do
                {
                    Console.WriteLine($"Entrenador {start.listTrainer[1].Name}!!!");
                    Console.Write("Ingresa el pokemon para la batalla: ");
                    _ = int.TryParse(Console.ReadLine(), out pokemon2);

                    if(pokemon2 < 0 || pokemon2 > maxLength)
                        Console.WriteLine("Error, vuelve a ingresar el valor");
                    
                } while (pokemon2 < 0 || pokemon2 > maxLength);

                entrenador1Start = false;
            }

            Senamon senamon1 = start.listTrainer[0].GetVectSenamon()[pokemon1];
            Senamon senamon2 = start.listTrainer[1].GetVectSenamon()[pokemon2];

            Trainer entrenador1 = start.listTrainer[0];
            Trainer entrenador2 = start.listTrainer[1];

            int turno = 0;
            int VictoriasEnt1 = 0, VictoriasEnt2 = 2;
            int victoriaEnt1 = start.listTrainer[0].WonBattles;
            int victoriaEnt2 = start.listTrainer[1].WonBattles;

            while (VictoriasEnt1 < 3 || VictoriasEnt2 < 3)
            {
                if (entrenador1Start)
                {
                    while (senamon1.Health > 0 && senamon2.Health > 0)
                    {
                        if (turno == 0)
                            senamon2.Health -= senamon1.Attack;
                        else if(turno == 1)
                            senamon1.Health -= senamon2.Attack;

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
                            senamon1.Health -= senamon2.Attack;
                        else if(turno == 1)
                            senamon2.Health -= senamon1.Attack;

                        turno++;
                        if (turno > 1)
                            turno = 0;
                    }
                }

                if (senamon1.Health <= 0)
                {
                    VictoriasEnt2 += 1;

                    start.listTrainer[0].ShowTeamSenamon();
                    do
                    {
                        Console.WriteLine($"Entrenador {start.listTrainer[0].Name}!!!");
                        Console.Write("Ingresa otro pokemon para la batalla: ");
                        _ = int.TryParse(Console.ReadLine(), out pokemon1);

                        if(pokemon1 < 0 || pokemon1 > maxLength)
                            Console.WriteLine("Error, vuelve a ingresar el valor");
                        
                    } while (pokemon1 < 0 || pokemon1 > maxLength);

                    senamon1 = start.listTrainer[0].GetVectSenamon()[pokemon1];

                }
                else if(senamon2.Health <= 0)
                {
                    VictoriasEnt1 += 1;

                    start.listTrainer[0].ShowTeamSenamon();

                    do
                    {
                        Console.WriteLine($"Entrenador {start.listTrainer[1].Name}!!!");
                        Console.Write("Ingresa otro pokemon para la batalla: ");
                        _ = int.TryParse(Console.ReadLine(), out pokemon2);

                        if(pokemon2 < 0 || pokemon2 > maxLength)
                            Console.WriteLine("Error, vuelve a ingresar el valor");
                        
                    } while (pokemon2 < 0 || pokemon2 > maxLength);

                    senamon2 = start.listTrainer[1].GetVectSenamon()[pokemon2];
                }                    
            }

            if(VictoriasEnt1 == 3)
            {
                victoriaEnt1 += 1;

                entrenador1.Experience += 100;
            }
            else if(VictoriasEnt2 == 3)
            {
                victoriaEnt2 += 1;

                entrenador2.Experience += 100;
            }
        }
    }
}